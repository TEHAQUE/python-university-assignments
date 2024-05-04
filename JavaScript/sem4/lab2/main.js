console.log("dasda");
window.document.body.style.backgroundColor = "black";

const $wrap = document.querySelector(".TxtWrap");
const $par1 = document.createElement("p");
const $btnWitam = document.createElement("button");
$btnWitam.innerHTML = "ayoo";
$btnWitam.addEventListener("click", function () {
  window.alert("witam ciebie");
});
$par1.innerHTML = "Hello and welcome!";
$wrap.appendChild($par1);
$wrap.appendChild($btnWitam);

async function fetchData() {
  try {
    const response = await fetch("https://api.coincap.io/v2/assets");
    const data = await response.json();
    displayData(data.data);
  } catch (error) {
    console.log(error);
  }
}

const $MainWrapper = window.document.querySelector(".layoutMain");
function displayData(coins) {
  coins.forEach((c) => {
    console.log(c);
    const wrapperEl = document.createElement("div");
    const Stitle = document.createElement("span");
    const Srank = document.createElement("span");
    const Ssymbol = document.createElement("span");
    const Sstock = document.createElement("span");
    const Sprice = document.createElement("span");
    const BtnBuy = document.createElement("button");

    BtnBuy.innerHTML = "Kupuj!";
    $MainWrapper.appendChild(wrapperEl);
    wrapperEl.classList.add("StockMainEl");
    BtnBuy.classList.add("btnBuy");
    Sprice.classList.add("price");
    Stitle.innerHTML = c.name;
    Srank.innerHTML = "Rank: " + c.rank;
    Ssymbol.innerHTML = "Symbol: " + c.symbol;
    Sstock.innerHTML = "Stock: " + Math.round(c.supply, 0, 2);
    Sprice.innerHTML = "Price: " + Math.round(c.priceUsd, 5) + " USD";

    wrapperEl.appendChild(Stitle);
    wrapperEl.appendChild(Srank);
    wrapperEl.appendChild(Ssymbol);
    wrapperEl.appendChild(Sstock);
    wrapperEl.appendChild(Sprice);
    wrapperEl.appendChild(BtnBuy);
  });
}

fetchData();
