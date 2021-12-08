let addBtns = document.querySelectorAll(".btn-primary");
function CreateBasketStorage() {
  if (!localStorage.getItem("basket")) {
    localStorage.setItem("basket", JSON.stringify([]));
  }
}
CreateBasketStorage();
function BasketProductCount() {
  document.querySelector("sup").innerText = JSON.parse(
    localStorage.getItem("basket")
  ).length;
}
BasketProductCount();
addBtns.forEach((item) => {
  item.addEventListener("click", function (e) {
    e.preventDefault();
    let Id = this.parentElement.parentElement.getAttribute("data-id");
    let Price = this.previousElementSibling.innerHTML;
    let Title = this.parentElement.firstElementChild.innerHTML;
    let Image = this.parentElement.previousElementSibling.getAttribute("src");
    CreateBasketStorage();
    let basket = JSON.parse(localStorage.getItem("basket"));
    let existProduct = basket.find((item) => item.id == Id);
    if (existProduct == undefined) {
      basket.push({
        id: Id,
        price: Price,
        title: Title,
        image: Image,
        count: 1,
      });
    } else {
      existProduct.count++;
    }
    console.log(basket);
    localStorage.setItem("basket", JSON.stringify(basket));
    BasketProductCount();
  });
});
function getBasket(Id, price, title, image) {
  let basket = JSON.parse(localStorage.getItem("basket"));
}
function createrow() {
    let tbody = document.querySelector(".tbody");
  let basket = JSON.parse(localStorage.getItem("basket"));
  basket.forEach(item =>{
    let newtd1 = document.createElement("td");
    newtd1.innerHTML = item.id;
    let newtd2 = document.createElement("td");
    newtd2.innerHTML=item.title;
    let newtd3 = document.createElement("td");
    newtd3.innerHTML=item.price;
    let newtd4 = document.createElement("td");
    let newtd4img = document.createElement("img")
    newtd4.appendChild(newtd4img)
    newtd4img.setAttribute("src",item.image)
    let newtd5 = document.createElement("td");
    newtd5.innerHTML=item.count;
    let newtd6 = document.createElement("td")
    let td6btn = document.createElement("button")
    td6btn.setAttribute("class","btn btn-danger")
    td6btn.innerHTML = "Delete";
    newtd6.appendChild(td6btn);
    td6btn.addEventListener("click",function (e){
      let table = document.querySelector(".table")
      console.log(table);
      tbody.deleteRow(this)

    })
    let newtr = document.createElement("tr");
    newtr.appendChild(newtd1)
    newtr.appendChild(newtd2)
    newtr.appendChild(newtd3)
    newtr.appendChild(newtd4)
    newtr.appendChild(newtd5)
    newtr.appendChild(newtd6)     
    tbody.appendChild(newtr)
  })
}
createrow();

