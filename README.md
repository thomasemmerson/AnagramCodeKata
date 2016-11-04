# AnagramCodeKata
Through my work as a Scrum Master at my current employer - BrightHR, based in Manchester - I have had the opportunity to devise and run several coding katas for my team-mates. This is one that I ran recently, based on an idea from www.codekata.com.

This solution is a C# - based console application, that is designed to take a  text file list of c.380,000 words, and output a new list of anagrams via the console.

So for example, if the input was:

cat
act
god
dog
stop
piecrust
pictures

The output should read:

act cat
cat act
dog god
god dog
pictures piecrust
piecrust pictures

This solution runs fine with a sample file containing 7 words; however, it runs extremely slowly with a list of c.380,000 words...

The purpose of this code kata is to refactor the public method named IsAnagramOf, which is found in the StringExtensions.cs file in the solution.
