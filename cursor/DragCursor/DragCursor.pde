/*
・身長と肩幅を順に測れるようにした
・1画素あたりのサイズ獲得できた
・肩幅を計測できた
・右クリックで初期化
・入力システム統合
・ウエスト（仮）身長，肩幅，チェスト前からと横から，ウエスト前からと横からの順に
・少し掃除した
・線引くとき，行き過ぎても大丈夫→前に計測した部分は消えるけど，もう必要ないしいいよね？
・if()をswitch()に変えた
・測定時に逆から測ると値がマイナスになるのを修正
*/

import java.awt.*;
import javax.swing.*;

int img_h = 3264;
int img_w = 2448;
int s = 7;
int x=0, y=0;       //座標保持
int count=0;
double height;      //身長
double lengh=0;     //長さ
double shoulder=0;  //肩幅
double chest=0;     //チェスト
double waist=0;     //ウエスト
double pixel=0;     //1画素あたりのサイズ
PImage img1;
PImage img2;

void setup() {

  size(1000, 600);

  img1 = loadImage("yuki_side.JPG");
  img2 = loadImage("yuki_front.JPG");

  image(img1, 0, 0, img_w/s, img_h/s);
  image(img2, 2448/s, 0, img_w/s, img_h/s);

  JPanel panel = new JPanel();
  BoxLayout layout = new BoxLayout(panel, BoxLayout.Y_AXIS);
  panel.setLayout(layout);

  panel.add(new JLabel("身長を入力してください"));
  JTextField text1 = new JTextField();
  panel.add(text1);
  panel.add(new JLabel("(cm)"));

  int r = JOptionPane.showConfirmDialog(
    null, // オーナーウィンドウ
    panel, // メッセージ
    "身長は？", // ウィンドウタイトル
    JOptionPane.OK_CANCEL_OPTION, // オプション（ボタンの種類）
    JOptionPane.QUESTION_MESSAGE);  // メッセージタイプ（アイコンの種類）

  //println(r);
  //println(text1.getText());

  height = Double.valueOf(text1.getText());
  //String型で入力されたやつをむりやりdoubleに変換

  // println(height);
}

void draw() {
/*
  fill(0, 0, 0);
  noStroke();
  smooth();

  if (mouseButton == LEFT) {
    if (count==0) {              //タッチした時にcountが1
      //     text("身長は"+height+"cm", 25, img1_h/s+50);
      rect(x, y, 4, mouseY-y);
      pixel = height / ((double)mouseY - (double)y);
    } else {
      rect(x, y, mouseX-x, 4);
      lengh = (double)(mouseX-x) * pixel;
    }
  }*/
}

void mousePressed() {
  
  fill(0, 0, 0);
  noStroke();
  smooth();
  
  switch (count){
    case 0:  rect(mouseX, mouseY, 20, 4);
                    rect(mouseX, mouseY, -20, 4);
                    x = mouseX;
                    y = mouseY;
                    break;
                    
    default: rect(mouseX, mouseY, 4, 20);
                    rect(mouseX, mouseY, 4, -20);
                    x = mouseX;
                    y = mouseY;
  }
}

void mouseDragged() {
  switch (count) {
    case 0:  image(img1, 0, 0, img_w/s, img_h/s);                  //縦の長い線
             image(img2, 2448/s, 0, img_w/s, img_h/s);
             rect(x, y, 20, 4);                                    //クリック時の固定線
             rect(x, y, -20, 4);
             rect(x, y, 4, mouseY-y);                              //動く線
             pixel = height / ((double)mouseY - (double)y);
             if (pixel<0) {                                        //逆から測るとマイナスになるため
              pixel = -1 * pixel;
             }
             break;
        
    default: image(img1, 0, 0, img_w/s, img_h/s);                  //横の長い線
             image(img2, 2448/s, 0, img_w/s, img_h/s);
             rect(x, y, 4, 20);                                    //クリック時の固定線
             rect(x, y, 4, -20);
             rect(x, y, mouseX-x, 4);                              //動く線
             lengh = (double)(mouseX-x) * pixel;
             if (lengh<0) {
              lengh = -1 * lengh;
             }
  }
}

void mouseReleased() {
  if (mouseButton == RIGHT) {                //カーソルキャンセル
    count = 0;                               //countと画面を初期化
    background(204);
    setup();
  } else {
    switch (count){
      case 0:  rect(x, mouseY, 20, 4);       //身長
               rect(x, mouseY, -20, 4);
               count++;
               break;
                      
      case 1:  tateline();                   //肩幅
               shoulder = lengh;
               showvalue(shoulder, "肩幅", 25);
               count++;
               break;
                      
      case 2:  tateline();                   //チェスト1
               chest = lengh*1.5;
               count++;
               break;
                      
      case 3:  tateline();                   //チェスト2
               chest += lengh*1.5;
               showvalue(chest, "チェスト", 300);
               count++;
               break;
                      
      case 4:  tateline();                   //ウエスト1
               waist = lengh * 1.5;
               count++;
               break;
                      
      case 5:  tateline();                   //ウエスト2
               waist += lengh*1.5;
               showvalue(waist, "ウエスト", 575);
               count++;
               break;
    }
  }
}

void tateline() {
  rect(mouseX, y, 4, 20);
  rect(mouseX, y, 4, -20);
}

void showvalue(double x, String a, int distance) {
  String after = String.format("%.2f", x);    //小数点第2まで表示
  text(a+after+"±1.00"+"cm", distance, img_h/s+50);
}