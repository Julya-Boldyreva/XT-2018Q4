function oneToLeft() {
	var len= document.getElementById("select1").options.length;
    for (var i = 0; i < len; i++)
    {
      if (document.getElementById("select1").options[i].selected==true)
      {
		var txt = document.getElementById("select1").options[i].text;
		var val = document.getElementById("select1").options[i].value;
		var newOption = new Option(txt, val);
		document.getElementById("select2").options[document.getElementById("select2").options.length]=newOption;
		
		var selectedIndex = document.getElementById("select1").options.selectedIndex;
		document.getElementById("select1").options[selectedIndex] = null;
      }
    }
}	

function allToLeft() {
	var len= document.getElementById("select1").options.length;
    for (var i = 0; i < len; i++)
    {
		var txt = document.getElementById("select1").options[i].text;
		var val = document.getElementById("select1").options[i].value;
		var newOption = new Option(txt, val);
		document.getElementById("select2").options[document.getElementById("select2").options.length]=newOption;
    }
	document.getElementById("select1").options.length = 0;
}			

function oneToRight() {
	var len= document.getElementById("select2").options.length;
    for (var i = 0; i < len; i++)
    {
      if (document.getElementById("select2").options[i].selected==true)
      {
		var txt = document.getElementById("select2").options[i].text;
		var val = document.getElementById("select2").options[i].value;
		var newOption = new Option(txt, val);
		document.getElementById("select1").options[document.getElementById("select1").options.length]=newOption;
		
		var selectedIndex = document.getElementById("select2").options.selectedIndex;
		document.getElementById("select2").options[selectedIndex] = null;
      }
    }
}	

function allToRight() {
	var len= document.getElementById("select2").options.length;
    for (var i = 0; i < len; i++)
    {
		var txt = document.getElementById("select2").options[i].text;
		var val = document.getElementById("select2").options[i].value;
		var newOption = new Option(txt, val);
		document.getElementById("select1").options[document.getElementById("select1").options.length]=newOption;
    }
	document.getElementById("select2").options.length = 0;
}			
				