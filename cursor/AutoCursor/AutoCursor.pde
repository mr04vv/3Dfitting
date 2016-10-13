int img_h = 3264;
int img_w = 2448;
int s = 7;
int x=0, y=0; 
PImage img1;
PImage img2;
int r, g, b;
int base, compare, eval;
int i;
int cursor_section=1;
int cursor_mode=0;   //0:holizontal, 1:vartical
int img_mode =1;     //1;img1, 2:img2

void setup() {

  size(1000, 600);

  img1 = loadImage("yuki_side.JPG");
  img2 = loadImage("yuki_front.JPG");

  image(img1, 0, 0, img_w/s, img_h/s);
  image(img2, 2448/s, 0, img_w/s, img_h/s);
}


void draw() {
}


void keyPressed(){
  if(key=='a')  {  set(0,1);  println("cursor:horizontal, img:1");  }
  if(key=='s')  {  set(1,1);  println("cursor:vartical, img:1");}
  if(key=='z')  {  set(0,2);  println("cursor:horizontal, img:2");}
  if(key=='x')  {  set(1,2);  println("cursor:vartical, img:2");}
}


void mousePressed() {

  fill(0, 0, 0);
  noStroke();
  smooth();

  switch(cursor_section) {
  case 1:
    x = mouseX;
    y = mouseY;
    println("x:"+x+",y:"+y);

    auto_cursor(x, y);

    println("end first section:"+eval);
    cursor_section=2;
    break;

  case 2:
    if (cursor_mode==0)
      y = mouseY;
    else
      x=mouseX;
    println("x:"+x+",y:"+y);

    auto_cursor(x, y);
    println("end second section:"+eval);
    cursor_section=1;
    break;
  }
}

void auto_cursor(int x, int y) {
  base=gray_scale(x, y);
  println("base:"+base);

  for (i=1;; i++) {
<<<<<<< HEAD
    if (i%2==1)
      y+=i;
    else
      y-=i;
=======
    switch(cursor_mode) {
    case 0:
      if (i%2==1)
        y+=i;
      else
        y-=i;
      break;

    case 1:
      if (i%2==1)
        x+=i;
      else
        x-=i;
      break;
    }
    println("y:"+y);
>>>>>>> fd80e0170278b572c21cd98ce75aa41d53413ee7
    println("x:"+x+",y:"+y);

    compare=gray_scale(x, y);
    println("compare:"+compare);

    eval=base-compare;
    if (eval<0)
      eval=-1*eval;

    if (eval>20) {
      switch(cursor_mode) {
      case 0:
        rect(x, y, 40, 1);
        rect(x, y, -40, 1);
        break;

      case 1:
        rect(x, y, 1, 40);
        rect(x, y, 1, -40);
        break;
      }
      break;
    }
  }
}

int gray_scale(int x, int y ) {
  r=int(red(img1.get(s*x, s*y)));
  g=int(green(img1.get(s*x, s*y)));
  b=int(blue(img1.get(s*x, s*y)));
  return int(0.33*r+0.59*g+0.11*b);
}


void set(int cursor_flag, int img_flag){
cursor_mode=cursor_flag;
img_mode=img_flag;
}