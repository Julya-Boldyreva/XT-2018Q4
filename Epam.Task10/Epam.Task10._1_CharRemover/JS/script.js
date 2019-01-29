function findDoubleSymbol(inputArr) {
	var splitt = "";
	var ch = '';
	var count = 0;
	var start = 0
	var end = 0;
	
	for(i = 0; i < inputArr.length; i++) {
		if(inputArr[i] != ' ' && inputArr[i] != '?' && inputArr[i] != '!' && inputArr[i] != ':' && inputArr[i] != ';' && inputArr[i] != ',' && inputArr[i] != '.'){
			ch = inputArr[i];
			count = 0;
			
			start = i;
			while(inputArr[i] != ' ' && inputArr[i] != '?' && inputArr[i] != '!' && inputArr[i] != ':' && inputArr[i] != ';' && inputArr[i] != ',' && inputArr[i] != '.' || i < inputArr[i].length) {
				if(inputArr[i] == ch) {
					count++;
				}
				i++;
				if(inputArr[i] == undefined) {
					break;
				}
			}
			if(count > 1) {
				splitt += ch;
			}
			end = i;
			
			if(end - start > 1)
			{
				for(j = start + 1; j < end; j++) {
					ch = inputArr[j];	
					count = 0;
					for(k = j; k < end; k++) {
						if(inputArr[k] == ch) {
							count++;
						}
						k++;
						if(inputArr[k] == undefined) {
							break;
						}
					}
					if(count > 1) {
						splitt += ch;
					}
				}
			}
		}
	}
	
	var res=inputArr;
	for(i = 0; i < splitt.length; i++) {
		for(j = 0; j < res.length; j++) {
			res = res.replace(splitt[i], "");
		}
	}
	return res;
}			
				
function removeChars() {
    //var str="У попа была собака, а не какая-нибудь корова";
	var str = document.getElementById('str').value;
	var res = findDoubleSymbol(str);
	document.getElementById('text').textContent = str;
	document.getElementById('res').textContent= res;
}