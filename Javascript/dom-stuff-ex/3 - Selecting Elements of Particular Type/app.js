const list = document.getElementsByTagName("li");
for(element of list) {
    element.style.color = "orange";
};

const notOrangeList = document.getElementsByClassName("not-orange");
for(element of notOrangeList) {
        element.style.color ="red";
    };
