Console.Clear();

string? word = "";

#pragma warning disable CS8602 // Dereference of a possibly null reference.
while (word.Length != 3) {
  Console.Write("Unesite rec od 3 slova: ");
  word = Console.ReadLine();
}
#pragma warning restore CS8602 // Dereference of a possibly null reference.

for (int i = 0; i < word.Length; i++) {
  Console.Write($"{word[i]}\t");
}
