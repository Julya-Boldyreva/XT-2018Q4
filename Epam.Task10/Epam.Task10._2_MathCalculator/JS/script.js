function calculate(str) {
	var pattern = /(\s)*(\d)+(\.(\d)+)?(\s)*([\+\-\*\/](\s)*(\d)+(\.(\d)+)?(\s)*)*\=/;
	if(!str.match(pattern)) {
		alert("Invalid expression!");
		return;
	}
	str = str.replace(/\s+/, "");
	var res = str;
	var patternOperators = /[\+\-\*\/\=]/g;
	var arrOperators = str.match(patternOperators);
	var arrNumbers = str.split(patternOperators);
	var resNumbers = Number.parseInt(arrNumbers[0]);
	for(var i = 0; i < arrOperators.length; i++) {	
		switch(arrOperators[i]) {
			case "+": resNumbers += Number.parseInt(arrNumbers[i+1]); break;
			case "-": resNumbers -= Number.parseInt(arrNumbers[i+1]); break;
			case "*": resNumbers *= Number.parseInt(arrNumbers[i+1]); break;
			case "/": resNumbers /= Number.parseInt(arrNumbers[i+1]); break;
			case "=": i = arrNumbers.length; break;
			default: break;
		}
	}
	res += resNumbers;		
    return res;
}

function calculateThis() {
	var str = document.getElementById('str').value;
	var res = calculate(str);
	document.getElementById('res').textContent = res;
}