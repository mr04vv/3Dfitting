//サイズ感判定

int shoulder = 300;
int west = 400;
int chest = 500;
int mode = 0;
int result;

void setup(){
    
  size(1000, 600);
  fill(0, 0, 0);
  noStroke();
  smooth();
  
  text("小さすぎ", 525, 270);
  text("タイト", 625, 270);
  text("ノーマル", 725, 270);
  text("ルーズ", 825, 270);
  text("だるだる", 925, 270);
  
  rect(550, shoulder, 400, 3 );    //肩幅
  rect(550, 290, 3, 24);    rect(650, 290, 3, 24);
  rect(750, 290, 3, 24);    rect(850, 290, 3, 24);
  rect(950, 290, 3, 24);
  text("肩幅", 520, 305);

  rect(550, west, 400, 3 );    //ウエスト
  rect(550, 390, 3, 24);    rect(650, 390, 3, 24);
  rect(750, 390, 3, 24);    rect(850, 390, 3, 24);
  rect(950, 390, 3, 24);
  text("ウエスト", 500, 405);
  
  rect(550, chest, 400, 3 );    //チェスト
  rect(550, 490, 3, 24);    rect(650, 490, 3, 24);
  rect(750, 490, 3, 24);    rect(850, 490, 3, 24);
  rect(950, 490, 3, 24);
  text("チェスト", 500, 505);
  
}

void draw(){
  /*
  if(keyPressed){
    switch (mode) {
      case 0:  size_impression(shoulder, result);
                      break;
                      
      case 1:  size_impression(west, result);
                      break; 
       
      case 2:  size_impression(chest, result);
                      break;                 
    }
    mode++;
  }
  */
}

void keyPressed() {      //とりあえず判定結果を0~4で識別
                                          //今後，各パーツの判定をここを書き換えて作る．
 if (key=='0') {
   result = 0;
 }else  if (key=='1') {
   result = 1;
 }else if (key=='2') {
   result = 2;
 }else if (key=='3') {
   result = 3;
 }else if (key=='4') {
    result = 4;
 }
  switch (mode) {
     case 0:  size_impression(shoulder, result);
                     break;
                      
     case 1:  size_impression(west, result);
                     break; 
      
     case 2:  size_impression(chest, result);
                     break;                 
   }
   mode++;
 
}

void size_impression(int which, int result){

  fill(0, 0, 0);
  smooth();
  ellipse(551 + 100*result, which+2, 10, 10);
}