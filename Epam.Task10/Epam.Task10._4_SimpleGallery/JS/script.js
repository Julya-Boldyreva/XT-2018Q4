var pic=new Array();
pic[0]="<img src='images/d0.jpg'>";//дни
pic[1]="<img src='images/d1.jpg'>";
pic[2]="<img src='images/d2.jpg'>";
pic[3]="<img src='images/d3.jpg'>";
pic[4]="<img src='images/d4.jpg'>";
pic[5]="<img src='images/d5.jpg'>";
pic[6]="<img src='images/d6.jpg'>";
pic[7]="<img src='images/d7.jpg'>";
pic[8]="<img src='images/d8.jpg'>";
pic[9]="<img src='images/d9.jpg'>";
pic[10]="<img src='images/d_tochki.jpg'>";//точки
pic[11]="<img src='images/d_dot.jpg'>";//точка

var p0Count = 9;
var setTime;
var flag0 = true;

function sw(t) {
	var r="";
	switch (t) {
		case 0: r+=pic[0]; break;
		case 1: r+=pic[1]; break;
		case 2: r+=pic[2]; break;
		case 3: r+=pic[3]; break;
		case 4: r+=pic[4]; break;
		case 5: r+=pic[5]; break;
		case 6: r+=pic[6]; break;
		case 7: r+=pic[7]; break;
		case 8: r+=pic[8]; break;
		case 9: r+=pic[9]; break;
		default: {
			p0Count = 9;
			document.location.href = "HTML/page1.html";
			clearTimeout(setTime);
		} break;
	}
	return r;	
}


function clock() {
	var res="";
	var secCat = sw(p0Count);
	res = secCat;
	p0Count--;
	document.getElementById("tim").innerHTML = res;
	setTime = setTimeout("clock()",1000);
}


function pause() {
	if(flag0){
		clearTimeout(setTime);
		flag0 = !flag0;
	}
	else{
		flag0 = !flag0;
		setTime = setTimeout("clock()",1000);
	}
}