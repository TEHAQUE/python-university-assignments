#include<iostream>
#include<fstream>
#include<string>
using namespace std;

bool liczebna(string liczba)
{
	int licz = 0;
	for(int i = 0; i < liczba.size(); i++)
		if(liczba[i]=='0') ++licz;
		else  --licz;
	
	if(licz>0) return true;
	
	return false;
}

int main()
{
	ifstream in("liczby.txt");
	
	if(in.is_open())
	{
		string liczba;
		int ile=0; 
		
		for(int i=0; i<1000; i++)
		{
			in>>liczba;
			if(liczebna(liczba)) ++ile;	
		}
		
		cout<<"Takich liczb jest: "<<ile<<endl;
		cin.get();
		in.close();
	}
	else
		cout<<"Problem z otwarciem pliku \"liczby.txt\"";
	
		
	return 0;
}
