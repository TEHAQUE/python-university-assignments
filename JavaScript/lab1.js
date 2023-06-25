let wynikA;
const zadA = (a) => {
    return wynikA = Array.from({ length: a }, () => Math.floor(Math.random() * 40) * 2 + 1);
}
zadA(7);
console.log(wynikA)

let wynikB;
const zadB = (a) => {
    return wynikB = [...a.filter(i => i % 3 === 0 || i % 5 === 0)]
}
console.log(zadB(wynikA))

const zadC = (a) => {
    return Math.floor([...a].reduce((a, b) => a + b) / a.length);
}
console.log(zadC(wynikA))
console.log(zadC(wynikB))

const zadD = (a) => {
    if (a < 2) return false;

    for (let i = 2, sqrt = Math.sqrt(a); i <= sqrt; i++) {
        if (a % i === 0) return false;
    }

    return true;
};
const zadE = wynikA.map(a => `${a}: ${zadD(a)}`);
console.log(zadE)