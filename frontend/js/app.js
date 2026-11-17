// ------- data ---------

const baseUrl = "http://localhost:5027/api";




//---------- elements ---------
// for say hello page
const nameInput = document.getElementById("name-input");
const nameButton = document.getElementById("name-button");
const greeting = document.getElementById("greeting");

//for sum page
const numberOne = document.getElementById("number-one");
const numberTwo = document.getElementById("number-two");
const addButton = document.getElementById("add-button");
const sumResult = document.getElementById("sum-result");
const sumForm = document.getElementById("sum-form");

//for comparison page
const compareOne = document.getElementById("compare-one");
const compareTwo = document.getElementById("compare-two");
const compareButton = document.getElementById("compare-button");
const compareForm = document.getElementById("compare-form");
const compareResult = document.getElementById("compare-result");


// ------- functions ---------

const additionFetch = async (numberOne,numberTwo) => {
     const res = await fetch(`${baseUrl}/sum/addition/${numberOne}/${numberTwo}`);
     const data = await res.json();
     console.log(data);
     return data;
}



const greetFetch = async (nameInput) => {
    const res = await fetch(`${baseUrl}/hello/greeting/${nameInput}`);
    const data = await res.json();
    console.log(data);
    return data;
}


const compareFetch = async (numOne,numTwo) => {
    const res = await fetch(`${baseUrl}/comparison/compare/${numOne}/${numTwo}`);
    const data = await res.json();
    console.log(data);
    return data;
}


//---------- listeners ---------

sumForm.addEventListener("submit", async (event) => {
     event.preventDefault();

     const result = await additionFetch(numberOne.value,numberTwo.value);

     sumResult.textContent = `${result.numOne} + ${result.numTwo} = ${result.result}`;
});

nameButton.addEventListener("click", async () => {
     const greet = await greetFetch(nameInput.value);
     
     greeting.textContent = `Hello ${greet.message}, nice to meet you`;
});

compareForm.addEventListener("submit", async (event) => {
    event.preventDefault();

    const output = await compareFetch(compareOne.value,compareTwo.value);
    
    if (output.compOne > output.compTwo) {
        compareResult.textContent = `${output.compOne} is greater than ${output.compTwo}`;
    } else if (output.compOne < output.compTwo) {
        compareResult.textContent = `${output.compOne} is less than ${output.compTwo}`;
    } else {
        compareResult.textContent = `${output.compOne} is equal to ${output.compTwo}`;
    }
});
// --------- run on load -------
