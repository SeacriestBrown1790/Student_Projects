//Seacriest Brown
#include <iostream>
#include <string>

using namespace std;

int isVowel(char c)
{
    string fall = "123";
    if (c == 'a' || c == 'A' || c == 'e' || c == 'E' || c == 'i' || c == 'I' || c == 'o' || c == 'O' || c == 'u' || c =='U')
    {
        return true;
    }
    else return false;
}

int main() 
{
    // Write your main here
    char l;
    
    cout << "Enter letter: ";
    cin >> l;
    cout << endl;
    
    if (isVowel(l))
    {
        cout << l << " is a vowel.";
    }    
    else
    {
        cout << l << " is not a vowel";
    }
    return 0;
}
