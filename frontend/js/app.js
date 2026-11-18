
//----------------Elements---------------
const username = document.getElementById("name-input");

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

//8-ball

const ballForm = document.getElementById("ball-form"); 
const ballOutput = document.getElementById("ball-output"); 

//Restuarant Picker
const restuarantForm = document.getElementById("restaurant-form"); 
const restuarantOutput = document.getElementById("restuarant-output"); 
const restuarantInput = document.getElementById("restuarant-input"); 

//Mad Lib
const madForm = document.getElementById("mad-form"); 
const madOutput = document.getElementById("mad-output"); 
const madName = document.getElementById("mad-name-input"); 
const animal = document.getElementById("animal-input"); 
const another = document.getElementById("another-input"); 
const madNum = document.getElementById("mad-num-input" ); 
const noun = document.getElementById("noun-input"); 
const color = document.getElementById("color-input"); 
const verb = document.getElementById("verb-input"); 
const place = document.getElementById("place-input"); 
const adj = document.getElementById("adj-input"); 
const food = document.getElementById("food-input"); 



const url = "http://localhost:5153/api/"

//--------------Functions------------------

async function madLib(name, animal, another, num, noun, color, verb, place, adj, food) {

    const response = await fetch(url + `mad/create/${name}/${animal}/${another}/${num}/${noun}/${color}/${verb}/${place}/${adj}/${food}`);
    const data = await response.json();
    console.log(data);
    return data;

}

async function pickRes(choice) {

    const response = await fetch(`${url}Restaurant/${choice}`);
    const data = await response.json();
    console.log(data);
    return data;

}

async function eightBall(){
    const response = await fetch(`${url}eight/response`);
    const data = await response.json(); 
    console.log(data); 
    return data; 
}

async function compareNum(num1,num2){
    const response = await fetch(`${url}greater/compare/${num1}/${num2}`)
    const data = await response.json();
    console.log(data);
    return data;
}

async function addNum(num1, num2) {
    const response = await fetch(`${url}add/add/${num1}/${num2}`)
    const data = await response.json();
    console.log(data);
    return data;
}

async function fetchName(newName) {

    const response = await fetch(url + "challenge/sayHello/" + newName);
    const data = await response.json();
    console.log(data);
    return data;

}

//------------Listeneres----------------
if (madForm != null) {
    madForm.addEventListener("submit", async function (event) {
        event.preventDefault();
        const output = await madLib(madName.value, animal.value, another.value, madNum.value, noun.value, color.value, verb.value, place.value, adj.value, food.value);
      
        madOutput.textContent = output.response;
        console.log("working");
        madOutput.className = "flex text-slate-200 p-2 justify-center my-5";
    });
}

if (restuarantForm != null) {
    restuarantForm.addEventListener("submit", async function (event) {
        event.preventDefault();
        const output = await pickRes(restuarantInput.value);
      
        restuarantOutput.textContent = output.response;
        console.log("working");
        restuarantOutput.className = "flex text-slate-200 p-2 justify-center my-5";
    });
}

if (ballForm != null) {
    ballForm.addEventListener("submit", async function (event) {
        event.preventDefault();
        const output = await eightBall();
        
        ballOutput.textContent = output.response;
        console.log("working");
        ballOutput.className = "flex text-slate-200 p-2 justify-center my-5";
    });
}
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