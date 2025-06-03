const button = document.querySelector("#submit");
const img = document.querySelector("img");

button.addEventListener("click", () => {
  if (img.style.display == "" || img.style.display == "block") {
    img.style.display = "none";
    button.textContent = "show";
  } else {
    img.style.display = "";
    button.textContent = "hide";
  }
});
