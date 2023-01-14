using System;
using System.Globalization;

namespace Session_05
{
    public class StringReverse
    {
        private string sequenceOfCharacters;

        public StringReverse(string sequenceOfCharacters){
            this.sequenceOfCharacters = sequenceOfCharacters;
        }

        private char[] GetStringArray(){
            char[] ArrayofAString = new char[sequenceOfCharacters.Length];
            for (int i = 0;  i < sequenceOfCharacters.Length; i++){
                ArrayofAString[i] = sequenceOfCharacters[i];
            }
            return ArrayofAString;
        }

        private char[] GetReversedArray(){
            char[] forwardCharacterArray = GetStringArray();
            char[] backwardCharacterArray = new char [forwardCharacterArray.Length];
            int j = 0;
            for (int i = forwardCharacterArray.Length - 1; i >= 0; i--){
                backwardCharacterArray[j] = forwardCharacterArray[i];
                j++;                
            }
            return backwardCharacterArray;
        }
        public void PrintReverseString(){
            char[] reversedArray = GetReversedArray();
            Console.Write("The reversed string is: ");
            foreach (char character in reversedArray){
                Console.Write(character);
            }
            Console.WriteLine($"{Environment.NewLine}");
        }
    }
}