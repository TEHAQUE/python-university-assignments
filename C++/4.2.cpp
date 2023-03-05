#include<iostream>
#include<fstream>
#include<string>
using namespace std;

bool czy_przez_dwa(string liczba)
{
	
	if(liczba[liczba.size()-1]=='0') 
		return true;
	return false;
}

bool czy_przez_osiem(string liczba)
{
	
	if(liczba[liczba.size()-1]=='0'&&
	liczba[liczba.size()-2]=='0'&&
	liczba[liczba.size()-3]=='0') 
		return true;
	
	return false;
}
int main()
{
	ifstream in("liczby.txt");
	
	if(in.is_open())
	{
		string liczba;
		int przez_dwa = 0, przez_osiem = 0; 
		
		for(int i=0; i<1000; i++)
		{
			in>>liczba;
			if(czy_przez_dwa(liczba)) ++przez_dwa;
			if(czy_przez_osiem(liczba)) ++przez_osiem;	
		}
		
		cout<<"Liczb podzielnych przez 2 jest: "<<przez_dwa<<endl;
		cout<<"Liczb podzielnych przez 8 jest: "<<przez_osiem<<endl;
		cin.get();
		in.close();
	}
	else
		cout<<"Problem z otwarciem pliku \"liczby.txt\"";
	
		
	return 0;
}
