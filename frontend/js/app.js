
//----------------Elements---------------
const username = document.getElementById("name-input");
//const nameButton = document.getElementById("name-button"); 
const nameOutput = document.getElementById("name-output");
const nameForm = document.getElementById("user-form");

const addForm = document.getElementById("add-form");
const input1 = document.getElementById("num-one");
const input2 = document.getElementById("num-two");
const numOutput = document.getElementById("num-output");

const compareForm = document.getElementById("compare-form");
const compareInputOne = document.getElementById("num1");
const compareInputTwo = document.getElementById("num2");
const compareOutput = document.getElementById("gnum-output");
const compareOutPutTwo = document.getElementById("gnum-output-two"); 


const url = "http://localhost:5153/api/challenge"
//--------------Functions------------------

async function compareNum(num1,num2){
    const response = await fetch(`${url}/compare/${num1}/${num2}`)
    const data = await response.json();
    console.log(data);
    return data;
}
compareNum(1, 2); 
async function addNum(num1, num2) {
    const response = await fetch(`${url}/add/${num1}/${num2}`)
    const data = await response.json();
    console.log(data);
    return data;
}

async function fetchName(newName) {

    const response = await fetch(url + "/sayHello/" + newName);
    const data = await response.json();
    console.log(data);
    return data;

}

//------------Listeneres----------------
if (addForm != null) {
    addForm.addEventListener("submit", async function (event) {
        event.preventDefault();
        const output = await addNum(input1.value, input2.value);

        input1.value = ""; 
        input2.value = ""; 

        numOutput.textContent = `${output.num1} + ${output.num2} = ${output.sum}`;
        console.log("working");
        numOutput.className = "flex text-slate-200 p-2 justify-center my-5";
    });
}
if (nameForm != null) {
    nameForm.addEventListener("submit", async function (event) {
        event.preventDefault();
        const output = await fetchName(username.value);
        username.value = ""; 
        nameOutput.textContent = output.response;
        console.log("working");
        nameOutput.className = "flex text-slate-200 p-2 justify-center my-5";
    });
}
if (compareForm != null) {
    compareForm.addEventListener("submit", async function (event) {
        event.preventDefault();
        const output = await compareNum(compareInputOne.value, compareInputTwo.value);

        compareOutput.textContent = output.compareOne;
        compareOutPutTwo.textContent = output.compareTwo; 

        compareInputOne.value = ""; 
        compareInputTwo.value = ""; 
        console.log("working");
        compareOutput.className = "flex text-slate-200 p-2 justify-center my-5";
    });
}