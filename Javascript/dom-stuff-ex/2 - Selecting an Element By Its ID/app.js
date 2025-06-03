const heading = document.getElementById("heading");
const button = document.getElementById("button");
const input = document.getElementById("input");

button.addEventListener("click",()=>{
        heading.style.color = input.value;
});