#include <iostream>
#include <stdlib.h>
#include <fstream>
#include <cstdlib>

using namespace std;

int main()
{

	int suma=0,il=0,liczba;
	string linia;
	fstream plik("sumowaniewierszy.txt");
	
	
	while(!plik.eof())
	{
		getline(plik, linia);
		cout<<linia<<"\t";
		liczba=atoi(linia.c_str());
		
			
		if (liczba%3==0) 
			{	
				il++;
			}
			
			while(liczba!=0)
			{
				suma+=liczba%10;
				liczba=liczba/10;
			}
			cout<<"Suma cyfr wynosi: "<<suma<<endl;	
			suma=0;		
	}

	
	cout<<endl<<il<<" Sposrod liczb jest podzielnych przez 3";
}
