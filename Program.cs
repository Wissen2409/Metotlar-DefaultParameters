

// Metot1 isimli metodu kullanalım

// 
Metot1();


Metot2();

Metot3(10,20);
Metot3(10);


Cevre(5,5);

// int tipinde parametre alan bir metot
// Bu metot parametre olarak almış olduğu a değişkeninin değerini default değer olarak belirleyebiliyoruz

// a değişkeninin default değeri 10'dur, metodu çağırırken, a değişkenine değer verilirse, verilen 
//değer a değişkenine gelecektir.
// ancak metodu çağırırken, a değişkenine değer verilmez ise, vermiş olduğunuz default değer ile çalışacaktır.
static void Metot1(int a=10){

Console.WriteLine(a);

}
static void Metot2(string value=""){

    // default parametre ile, parametre olarak string değer gönderilmezse, parametrenin değerinin boşluk karakteri 
    // olarak verdik.
    Console.WriteLine(value);
}
static void Metot3(int a,int b=100){

    Console.WriteLine(a);
    Console.WriteLine(b);
}
static void Cevre(int yariCap,double pi=Math.PI){
  
  Console.WriteLine(2*pi-yariCap);
}