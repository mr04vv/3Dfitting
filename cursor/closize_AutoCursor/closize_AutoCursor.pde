int img_h = 3264;
int img_w = 2448;
int s = 7;
int x=0, y=0; 
PImage img1;
PImage img2;

void setup() {

  size(1000, 600);

  img1 = loadImage("yuki_side.JPG");
  img2 = loadImage("yuki_front.JPG");

  image(img1, 0, 0, img_w/s, img_h/s);
  image(img2, 2448/s, 0, img_w/s, img_h/s);
}

void draw() {
}

int r, g, b;
int base, compare, eval;
int i,j;

void mousePressed() {

  fill(0, 0, 0);
  noStroke();
  smooth();

  x = mouseX;
  y = mouseY;
  //デバック用に座標を表示
  println("x:"+x+",y:"+y);
  
  //指定画素のRGBを取得してグレースケール化
  r=int(red(img1.get(s*x, s*y)));
  g=int(green(img1.get(s*x, s*y)));
  b=int(blue(img1.get(s*x, s*y)));
  base=int(0.33*r+0.59*g+0.11*b);  //クリックした画素を基準値に
  //デバック用に基準値を表示
  println("base:"+base);

  for (i=1;; i++) {
    //画素を縦方向に探索
    if(i%2==1)
    y+=i;
    else
    y-=i;
    
    //デバック用に座標を表示
    println("x:"+x+",y:"+y);
    
    //指定画素のRGBを取得してグレースケール化
    r=int(red(img1.get(s*x, s*y)));
    g=int(green(img1.get(s*x, s*y)));
    b=int(blue(img1.get(s*x, s*y)));
    compare=int(0.33*r+0.59*g+0.11*b);  //探索した画素を比較値に
    
    //デバック用に比較値を表示
    println("compare:"+compare);
    eval=base-compare;  //基準値と比較値の差を評価値に
    if (eval<0)        //評価値の絶対値
      eval=-1*eval;
    if (eval>20) {      //評価値が閾値以上ならカーソルを描画
      rect(x, y, 20, 1);
      rect(x, y, -20, 1);
      break;
    }
  }
  //デバック用に評価値を表示
  println("eval:"+eval+"...end");
}