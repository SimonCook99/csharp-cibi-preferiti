string[] cibiPreferiti = { "pasta al sugo", "sushi", "pasta al burro", "pizza", "carbonara"};

Console.WriteLine("La lista contiene " + cibiPreferiti.Length + " elementi");

for(int i = 0; i < cibiPreferiti.Length; i++){
    Console.WriteLine("Posizione n° " + i + ": " + cibiPreferiti[i]);
}


Console.WriteLine("Il cibo migliore è: " + cibiPreferiti[cibiPreferiti.Length - 1]);

Console.WriteLine("Il cibo peggiore è: " + cibiPreferiti[0]);
