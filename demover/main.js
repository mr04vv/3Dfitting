var body_shoulder;
var body_chest=90;
var body_waist=70;
var shoulder_size;
var chest_size;
var waist_size;
var sizeflag;

<!--チェスト、ウエストは中央値-->
function Data(shoulder, chest, waist){
    this.shoulder = shoulder;
    this.chest = chest;
    this.waist = waist;
}

<!--MEN ウォッシュボーダー-->
var uniT_xs = new Data(40,84,72);
var uniT_s = new Data(41.5,88,76);
var uniT_m = new Data(43,96,84);
var uniT_l = new Data(44.5,104,92);
var uniT_xl = new Data(46.5,112,100);

function setSizeFlag(flag){
    sizeflag=flag;
}

function Dataset(){
    var clone = decodeURIComponent(location.search.substring(1));
    clone = clone.split('&');
    body_shoulder = clone[0];
    body_chest = clone[1];
    body_waist = clona[2];
}


function ClosizeCalclation(clothes_shoulder, clothes_chest, clothes_waist){
    sizeflag=2;
    shoulder_size = body_shoulder - clothes_shoulder;
    chest_size = body_chest - clothes_chest;
    waist_size = body_waist - clothes_waist;
}

function jump_main(){
    location.href="../main/index.html?"+body_shoulder+"&"+body_chest+"&"+body_waist;
}

function push(btnNo){
if (btnNo == 1){
   location.href = "../measure/measure.html";
}else if(btnNo == 2){
   location.href = "../tryon/tryon.html?"+location.search.substring(1);
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
    location.href = "uniT/uniT.html?"+location.search.substring(1);
}/*tシャツを選択した場合*/

function jump_uniB(){
	location.href = "uniB/uniB.html?"+location.search.substring(1);
}/*パンツを選択した場合*/

function jump_check(){
	location.href = "../../check/check.html?"+location.search.substring(1);
}

function jump_tryon(){
	location.href = "../tryon/tryon.html";
}


    
