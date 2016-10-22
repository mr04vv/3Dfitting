var h = 169;
var body_shoulder =40;
var body_chest = 90;
var body_waist = 80;
var shoulder_size;
var chest_size= 10 ;
var waist_size;

<!--チェスト、ウエストは中央値-->
function Data(shoulder, chest, waist){
    this.shoulder = shoulder;
    this.chest = chest;
    this.waist = waist;
}

<!--MEN ウォッシュボーダー-->
var uniT_xs = new Data(40,81,69);
var uniT_s = new Data(41.5,84,72);
var uniT_m = new Data(43,92,80);
var uniT_l = new Data(44.5,100,88);
var uniT_xl = new Data(46.5,108,96);


function ClosizeCalclation(clothes_shoulder, clothes_chest, clothes_waist){
    shoulder_size = body_shoulder - clothes_shoulder;
    chest_size = body_chest - clothes_chest;
    waist_size = body_waist - clothes_waist;
    location.href = "../size.html";
}

function jump_main(){
    location.href="../main/index.html";
}

function push(btnNo){
if (btnNo == 1){
   location.href = "../measure/measure.html";
}else if(btnNo == 2){
   location.href = "../tryon/tryon.html";
}else if(btnNo == 3){
   location.href = "men/men.html";
}else if(btnNo == 4){
   location.href = "women/women.html";
}
}

function jump_cursor(){
   location.href = "../../cursor/cursor.html";
}

function jump_uniT(){
    location.href = "uniT/uniT.html";
}/*tシャツを選択した場合*/

function jump_uniB(){
	location.href = "uniB/uniB.html";
}/*パンツを選択した場合*/

function jump_check(){
	location.href = "../../check/check.html";
}

function jump_tryon(){
	location.href = "../tryon/tryon.html";
}


    
