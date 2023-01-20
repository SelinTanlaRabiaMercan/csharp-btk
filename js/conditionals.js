//En büyük sayıyı bulma (if)

var sayi1=67
var sayi2=78
var sayi3=94

var enBuyuk = sayi1

if(enBuyuk<sayi2){
    enBuyuk=sayi2
}if(enBuyuk<sayi3){
    enBuyuk=sayi3
}

console.log("en büyük sayı "+enBuyuk)

console.log("------------------------")

//1 den 10 a kadar sayıları yazdırma (while)

var sayi=1

while(sayi<=10){
    console.log(sayi)
    sayi++
}

console.log("------------------------")

//1 den 10 a kadar sayıları yazdırma (for)

for (var i=0; i <=10; i++) {
   console.log(i)
}

console.log("------------------------")

//iç içe for döngüsü

function sayiUret(standart1 = 50){
    return Math.ceil(Math.random()*standart1)
}

for(var i=1;i<6;i++){
    console.log(i+".kolon")
    for(var j=0;j<6;j++){
        console.log(sayiUret())
    }
}