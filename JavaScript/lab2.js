< !DOCTYPE html >
    <html lang="en">
        <head>
            <meta charset="UTF-8">
                <meta name="viewport" content="width=device-width, initial-scale=1.0">
                    <title>Document</title>
</head>
                <body>
                    <style>
                        *{
                            margin: 0px;
    }
                        section{
                            width: 400px;
                        height: 250px;
                        background-color: rgb(7, 60, 7);
                        border: 1px solid rgb(11, 57, 11);
                        border-radius: 15px;
                        box-shadow: 0px 0px 10px rgb(20, 17, 17);
                        overflow: hidden;
    }
                        body{
                            display: flex;
                        justify-content: center;
                        align-items: center;
                        height: 100dvh;
                        background-color: rgb(15, 96, 15);
    }
    section>div:nth-child(1){
                            width: 100%;
                        height: 20%;
                        background-color: rgb(22, 100, 22);
    }
    section>div:nth-child(2){
                            width: 100%;
                        height: 60%;
    }
    section>div:nth-child(3){
                            background - color: green;
                        width: 100%;
                        height: 20%;
    }
                    </style>
                    <section>
                        <div>
                            <p>balance: </p><p></p>
                        </div>
                        <div>
                            <p id="symbol"></p>
                            <p id="profit"></p>
                            <p id="komunikat"></p>
                        </div>
                        <div>
                            <input type="number" placeholder="monety">
                                <input type="button" value="spin" onclick="spin()">
    </div>
</section>
</body>
                        <script>
                            const powers = [
                            {znak: "A", x: 2 },
                            {znak: "B", x: 9 },
                            {znak: "C", x: -10 },
                            {znak: "D", x: 11 },
                            {znak: "E", x: -5 }
                            ]
                            let base = 2;
                            let balance = 0;
let balanceDraw = document.querySelector("body > section > div:nth-child(1) > p:nth-child(2)");
let newBase = document.querySelector("body > section > div:nth-child(3) > input[type=number]:nth-child(1)");
                            let komunikat = document.querySelector("#komunikat");
                            let symbol = document.querySelector("#symbol");
                            let profit = document.querySelector("#profit");
                            balanceDraw.innerHTML = balance;
const spin=()=>{
                                let newBase2=0;
                            if(newBase.value !==''){
                                newBase2 = newBase.value;
                            komunikat.innerHTML = ''
    }
                            if(balance === 0){
                                komunikat.innerHTML = 'Nie masz wiêcej monet'
                            }

                            const losowanie = powers[Math.floor(Math.random() * powers.length)];
                            symbol.innerHTML = losowanie.znak;
                            let wygrana = parseInt(losowanie.x * newBase2);
        if (wygrana > 0) {
                                balanceDraw.innerHTML = balance += wygrana;
                            profit.innerHTML = `+ ${wygrana}`;
        } else {
                                balanceDraw.innerHTML = balance = balance - Math.abs(wygrana);
                            profit.innerHTML = wygrana;
    }

}
                        </script>
</html>