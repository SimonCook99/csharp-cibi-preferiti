string[] cibiPreferiti = { "pasta al sugo", "sushi", "pasta al burro", "pizza", "carbonara"};

Console.WriteLine($"La lista contiene {cibiPreferiti.Length} elementi");

//for(int i = 0; i < cibiPreferiti.Length; i++){
//    Console.WriteLine($"Posizione n° {i} : {cibiPreferiti[i]}"  );
//}


//Console.WriteLine($"Il cibo preferito è: {cibiPreferiti[cibiPreferiti.Length - 1]} ");

//Console.WriteLine($"Il cibo peggiore è: {cibiPreferiti[0]}");


//if(cibiPreferiti.Length %2 != 0){ //se la lunghezza dell'array è dispari...
//    string elementoMediano = cibiPreferiti[cibiPreferiti.Length / 2];
//    Console.WriteLine(elementoMediano);
//}
//else{ // se la lunghezza è pari...
//    Console.WriteLine(cibiPreferiti[cibiPreferiti.Length / 2 - 1]);
//    Console.WriteLine(cibiPreferiti[(cibiPreferiti.Length / 2)]);
//}

string ciboUtente;
do
{
    Console.WriteLine("inserisci il tuo cibo preferito");
    ciboUtente = Console.ReadLine();
    Console.WriteLine(ciboUtente);
    Console.WriteLine(cibiPreferiti.Contains(ciboUtente));

} while (!cibiPreferiti.Contains(ciboUtente));


Random random = new Random();
int numero = 3; /*random.Next(0, cibiPreferiti.Length - 1);*/
Console.WriteLine(numero);

Console.WriteLine($"Il cibo preferito è: {cibiPreferiti[numero]} ");

for (int i = 0; i < cibiPreferiti.Length; i++){

    if (cibiPreferiti[i] == ciboUtente && cibiPreferiti[i] == cibiPreferiti[numero]){
        Console.WriteLine($"Posizione n° {i} : {cibiPreferiti[i]} -->abbiamo gli stessi gusti");
    }else if (cibiPreferiti[i] == cibiPreferiti[numero]){
        Console.WriteLine($"Posizione n° {i} : {cibiPreferiti[i]} -->questo è il mio cibo preferito");
    }else if (cibiPreferiti[i] == ciboUtente){
        Console.WriteLine($"Posizione n° {i} : {cibiPreferiti[i]} -->questo è il tuo cibo preferito");
    }else{
        Console.WriteLine($"Posizione n° {i} : {cibiPreferiti[i]}");
    }
}
