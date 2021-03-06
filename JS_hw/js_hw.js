/*
1.We have an object storing salaries of our team
let salaries = {
	John: 100,
	Ann: 160,
	Pete: 130}
Write the code to sum all salaries and store in the variable sum. 
Should be 390 in the example above.
*/

let salaries = {
	John: 100,
	Ann: 160,
	Pete: 130}

let sum = 0;
for (let i in salaries){
	sum += salaries[i];
} 
console.log("the sum of salaries is " + sum);

/*
2.Create a function multiplyNumeric(obj) that multiplies all numeric properties of obj by 2
// before the call
let menu = {
	width: 200,
	height: 300,
	title: "My menu"};
multiplyNumeric(menu);

// after the call
menu = {
	width: 400,
	height: 600,
	title: "My menu"};
Please note that multiplyNumeric does not need to return anything. It should modify the object in
*/

let menu = {
	width: 200,
	height: 300,
	title: "My menu"};
multiplyNumeric(menu);

function multiplyNumeric(obj){
	for (let i in obj){
		if(typeof obj[i] == 'number'){
			obj[i] *= 2;
		}
	}
}

console.log(menu);

/*
3.Write a function checkEmailId(str) that returns true if str contains '@' and ‘.’, otherwise false. 
Make sure '@' must come before '.' and there must be some characters between '@' and '.'
The function must be case-insensitive:
*/

const str = '1234@gmail.com';
checkEmailId(str) 

let checkstr ='';
function checkEmailId(obj){
	console.log(obj.includes('@') && obj.includes('.'));
}


/*
4.Create a function truncate(str, maxlength) that checks the length of the str and, if it exceeds maxlength
replaces the end of str with the ellipsis character "...", to make its length equal to maxlength.
The result of the function should be the truncated (if needed) string.
truncate("What I'd like to tell on this topic is:", 20) = "What I'd like to te..."
truncate("Hi everyone!", 20) = "Hi everyone!"
*/




 function truncate(str, maxlength) {
 	let len = str.length, new_str;
 	if (len > maxlength){
 		new_str = str.slice(0, maxlength - 1) ;
 		console.log(new_str + "...");
 	}
 	else{
 		console.log(str);

 	}
      //console.log(str);
      //console.log(maxlength);
}
truncate("What I'd like to tell on this topic is:", 20);
truncate("Hi everyone!", 20);

/*
Let’s try 5 array operations.
Create an array styles with items “James” and “Brennie”.
Append “Robert” to the end.
Replace the value in the middle by “Calvin”. 
Your code for finding the middle value should work for any arrays with odd length.
Remove the first value of the array and show it.
Prepend Rose and Regal to the array.
James, Brennie
James, Brennie, Robert
James, Calvin, Robert
Calvin, Robert
Rose, Regal, Calvin, Robert
*/

let name = ["James", "Brennie"];
console.log(name);
/*print the array out by loop
for (let key in name){
	console.log(name[key]);
}
*/
name.push("Robert");
console.log(name);
name[Math.floor((name.length - 1) / 2)] = "Calvin";
console.log(name);
name.shift();
console.log(name);
name.unshift("Rose","Regal");
console.log(name);



