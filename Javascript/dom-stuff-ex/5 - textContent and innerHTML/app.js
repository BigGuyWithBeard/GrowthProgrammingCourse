const input = document.querySelector("#input");
const submit = document.querySelector("#submit");
const list = document.querySelector("#list");
const h1 = document.querySelector("h1");

submit.addEventListener("click", () => {
  h1.style.color = "goldenrod";
  //h1.textContent = `<li>${input.value}</li>`;
  list.innerHTML += `<li>${input.value}</li>`;
});
