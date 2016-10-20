/*
仕様
 クリックした画素に対して縦or横方向に探索をかけてエッジ（色の変化の大きいところ）にカーソルが出る.
 2個目のカーソルはその方向の座標を保存して表示.
 デバック用にコンソールにメッセージを表示.メッセージの内容は以下の通り.
 x,y:探索した画素の座標
 base:最初にクリックした画素のグレースケール値.
 compare:探索した画素のグレースケール値.
 eval:評価値
 first section,second section:カーソルの回数.first:一回目,second:二回目.
 cursor mode cganged:カーソルモードの変更.直後に変更内容.
 */

/*
 詳細?
 クリックした画素を基準値(base)として探索をかけた画素を比較値(conpare)とする.基準値と比較値に差を評価値(eval)として,
 これが閾値(現在20に設定)より大きければカーソルを表示.
 */


int img_h = 3264;
int img_w = 2448;
int s = 7;
int x=0, y=0; 
int prex, prey;
PImage img1;
PImage img2;
int r, g, b;
int base, compare, eval;
int i;
int cursor_section=1;
int cursor_mode=0;   //0:holizontal, 1:vartical
int img_mode=1;     //1;img1, 2:img2
int Xoffset, Yoffset;
float ans;
float height=169;
float pixel;
float l;  //length
int measure_mode=0;
float shoulder;
int mode;  //全体の流れ管理用


void setup() {

  size(1000, 600);

  img1 = loadImage("yuki_side.jpg");
  img2 = loadImage("yuki_front.jpg");

  image(img1, 0, 0, img_w/s, img_h/s);
  image(img2, 2448/s, 0, img_w/s, img_h/s);
  
  pixel=0;
  println(img_h/s +"  " + img_w/s);
}


void draw() {
}


void keyPressed() {
  if (key!='q' || key!='u' || key!='d') {
    if (key!='u' && key!='d' && key!='l' && key!='r')  println("cursor mode changed");
    
    if (key=='a') {  
      set(0, 1);  
      println("cursor:horizontal, img:side");
    }
    
    if (key=='s') {  
      set(1, 1);  
      println("cursor:vartical, img:side");
    }
    
    if (key=='z') {  
      set(0, 2);  
      println("cursor:horizontal, img:front");
    }
    
    if (key=='x') {  
      set(1, 2);  
      println("cursor:vartical, img:front");
    }
    
    if (key=='u'){
      println("move up");
      if (cursor_section==2){
          image(img1, 0, 0, img_w/s, img_h/s);
          image(img2, 2448/s, 0, img_w/s, img_h/s);
          prey--;
          rect(x, prey, 40, 1);
          rect(x, prey, -40, 1);
      } else {
          image(img1, 0, 0, img_w/s, img_h/s);
          image(img2, 2448/s, 0, img_w/s, img_h/s);
          rect(prex, prey, 40, 1);
          rect(prex, prey, -40, 1);
          y--;
          rect(x, y, 40, 1);
          rect(x, y, -40, 1);
          measure_mode = 0;
          pixel = 0;
          measure();
      }
    }
    
    if (key=='d'){
      println("move down");
      if (cursor_section==2){
          image(img1, 0, 0, img_w/s, img_h/s);
          image(img2, 2448/s, 0, img_w/s, img_h/s);
          prey++;
          rect(x, prey, 40, 1);
          rect(x, prey, -40, 1);
      } else {
          image(img1, 0, 0, img_w/s, img_h/s);
          image(img2, 2448/s, 0, img_w/s, img_h/s);
          rect(prex, prey, 40, 1);
          rect(prex, prey, -40, 1);
          y++;
          rect(x, y, 40, 1);
          rect(x, y, -40, 1);
          measure_mode = 0;
          pixel = 0;
          measure();
      }
    }
    
    if (key=='l'){
      println("move left");
      if (cursor_section==2){
          image(img1, 0, 0, img_w/s, img_h/s);
          image(img2, 2448/s, 0, img_w/s, img_h/s);
          prex--;
          rect(prex, y, 1, 40);
          rect(prex, y, 1, -40);
      } else {
          image(img1, 0, 0, img_w/s, img_h/s);
          image(img2, 2448/s, 0, img_w/s, img_h/s);
          rect(prex, prey, 1, 40);
          rect(prex, prey, 1, -40);
          x--;
          rect(x, y, 1, 40);
          rect(x, y, 1, -40);
          measure();
      }
    }
    
    if (key=='r'){
      println("move right");
      if (cursor_section==2){
          image(img1, 0, 0, img_w/s, img_h/s);
          image(img2, 2448/s, 0, img_w/s, img_h/s);
          prex++;
          rect(prex, y, 1, 40);
          rect(prex, y, 1, -40);
      } else {
          image(img1, 0, 0, img_w/s, img_h/s);
          image(img2, 2448/s, 0, img_w/s, img_h/s);
          rect(prex, prey, 1, 40);
          rect(prex, prey, 1, -40);
          x++;
          rect(x, y, 1, 40);
          rect(x, y, 1, -40);
          measure();
      }
    }
    
    
  } else {
    setup();
    cursor_section=1;
    println("reset cursor");
  } 
}


void mousePressed() {

  fill(0, 0, 0);
  noStroke();
  smooth();

  switch(cursor_section) {
   case 1:  mode_select();
                    x = mouseX;
                    y = mouseY;
                    println("x:"+x+",y:"+y);

                    auto_cursor();
                    prex=x;
                    prey=y;

                    println("end first section:"+" eval:"+eval);
                    cursor_section=2;
                    break;

    case 2:  if (cursor_mode==0)
                      y = mouseY;
                    else
                      x = mouseX;
                    
                    println("x:"+x+",y:"+y);

                    auto_cursor();
                    println("end second section:"+" eval:"+eval);
                    cursor_section=1;
    
                    measure();
                    break;
  }
}


void auto_cursor(){
  
  base=gray_scale(x, y);
  println("base:"+base);

  for (i=1;; i++) {
    
    switch(cursor_mode) {
      case 0:  if (i%2==1)
                        y+=i;
                      else
                        y-=i;
                      break;

      case 1:  if (i%2==1)
                        x+=i;
                      else
                        x-=i;
                      break;
    }
    
    println("x:"+x+",y:"+y);

    compare=gray_scale(x, y);
    println("compare:"+compare);

    eval=base-compare;
    if (eval<0)
      eval=-1*eval;

    if (eval>20) {
      switch(cursor_mode) {
      case 0:  rect(x, y, 40, 1);
                      rect(x, y, -40, 1);
                      break;

      case 1:  rect(x, y, 1, 40);
                      rect(x, y, 1, -40);
                      break;
      }
      break;
    }
  }
}


int gray_scale(int x, int y ) {
  
  if (img_mode==1) {
    r=int(red(img1.get(s*(x-Xoffset), s*(y-Yoffset))));
    g=int(green(img1.get(s*(x-Xoffset), s*(y-Yoffset))));
    b=int(blue(img1.get(s*(x-Xoffset), s*(y-Yoffset))));
    
  } else {
    r=int(red(img2.get(s*(x-Xoffset), s*(y-Yoffset))));
    g=int(green(img2.get(s*(x-Xoffset), s*(y-Yoffset))));
    b=int(blue(img2.get(s*(x-Xoffset), s*(y-Yoffset))));
  }
  
  return int(0.33*r+0.59*g+0.11*b);
}


void set(int cursor_flag, int img_flag) {
  
  cursor_mode=cursor_flag;
  img_mode=img_flag;
  if (img_mode==2)
    Xoffset=img_w/s;
}


void measure(){
  
  switch(measure_mode){
    case 0:  calculation();    //calculat pixel
                    measure_mode++;
                    break;
    
    case 1:  shoulder=calculation();    //calculat shoulder
                    println("syoulder:"+shoulder);
                    // measure_mode++;
                    break;
  }
}


float calculation() {
  
  if (cursor_mode==0) {
    l=prey-y;
    println("prey:"+prey+" y:"+y);
    
    if (l<0)  l=-1*l;
      
    if (pixel==0){
      pixel=height/l;
      println("pixel:"+pixel);
    }else{
      ans=l*pixel;
    }
    
  } else {
    l=prex-x;
    println("prex:"+prex+" x:"+x);
    if (l<0)  l=-1*l;
    ans=l*pixel;
  }
  
  return ans;
}


void mode_select(){
  
 switch(mode){
  case 0:  set(0,1);    //height
                  mode++;
                  break;
  
  case 1:  set(1,2);  //shoulder
                  break;
 }
}