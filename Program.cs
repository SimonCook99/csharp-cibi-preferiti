string[] cibiPreferiti = { "pasta al sugo", "sushi", "pasta al burro", "pizza"};

Console.WriteLine($"La lista contiene {cibiPreferiti.Length} elementi");

for(int i = 0; i < cibiPreferiti.Length; i++){
    Console.WriteLine($"Posizione n° {i} : {cibiPreferiti[i]}"  );
}


Console.WriteLine($"Il cibo migliore è: {cibiPreferiti[cibiPreferiti.Length - 1]} ");

Console.WriteLine($"Il cibo peggiore è: {cibiPreferiti[0]}");


if(cibiPreferiti.Length %2 != 0){ //se la lunghezza dell'array è dispari...
    //Console.WriteLine(cibiPreferiti.Length / 2);
    string elementoMediano = cibiPreferiti[cibiPreferiti.Length / 2];
    Console.WriteLine(elementoMediano);
}
else{ // se la lunghezza è pari...
    Console.WriteLine(cibiPreferiti[cibiPreferiti.Length / 2 - 1]);
    Console.WriteLine(cibiPreferiti[(cibiPreferiti.Length / 2)]);
}
