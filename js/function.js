//random() : random sayı : 0 ve 1 arasında üretir bu yüzden 49 ile çarpıyorum
//ceil() : sayıyı yukarı yuvarlar
function sayiUret(standart1 = 50){
    return Math.ceil(Math.random()*standart1)
}

var sayi =sayiUret()
var sayi1=sayiUret(89)
var sayi2=sayiUret()
var sayi3=sayiUret(10000)
var sayi4=sayiUret()

console.log(sayi+' '+sayi1+' '+sayi2+' '+sayi3+' '+sayi4)
