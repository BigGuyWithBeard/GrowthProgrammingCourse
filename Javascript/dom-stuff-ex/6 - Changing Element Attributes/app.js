const submit = document.querySelector("#submit");
const image = document.querySelector("#image");
const input = document.querySelector("#input");

submit.addEventListener("click", function (e) {
  image.src = input.value;
});
