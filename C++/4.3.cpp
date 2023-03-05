#include<iostream>
#include<fstream>
#include<string>
using namespace std;
int main()
{
	ifstream in("liczby.txt");
	
	if(in.is_open())
	{
		
		string liczba, Min, Max;

		int nrMin = 1, nrMax = 1;
		
		in>>liczba;
		
		Min=Max=liczba;
		
		for(int i=2; i<1001; i++)
		{
			in>>liczba;
			if(liczba.size() > Max.size())
			{
				Max = liczba;
				nrMax = i;
			} 
			else
				if(liczba.size()==Max.size())
					if(liczba > Max)
					{
					
						Max = liczba;
					
						nrMax = i;
					}
			if(liczba.size() < Min.size())
			{
				Min = liczba;
				nrMin = i;
			} 
			else
				if(liczba.size()==Min.size())
					if(liczba < Min)
					{
						
						Min = liczba;
						nrMin = i; 
					}	
		}
		
		cout<<"Najmniejsza znajduje sie we wierszu: "<<nrMin<<endl;
		cout<<"Najwieksza znajduje sie we wierszu: "<<nrMax<<endl;
		cin.get();
		in.close();
	}
	else
		cout<<"Problem z otwarciem pliku \"liczby.txt\"";
	
		
	return 0;
}
