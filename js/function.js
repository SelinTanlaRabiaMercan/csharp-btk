//random() : random sayı : 0 ve 1 arasında üretir bu yüzden 49 ile çarpıyorum
//ceil() : sayıyı yukarı yuvarlar
function sayiUret(){
    return Math.ceil(Math.random()*49)
}

var sayi =sayiUret()
var sayi1=sayiUret()
var sayi2=sayiUret()
var sayi3=sayiUret()
var sayi4=sayiUret()

console.log(sayi+' '+sayi1+' '+sayi2+' '+sayi3+' '+sayi4)
