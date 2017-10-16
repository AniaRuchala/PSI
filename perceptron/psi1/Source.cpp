#include <iostream>
#include <fstream>
#include "Neuron.h"

using namespace std;

double* csvReader(string file);

double funcAct(double x){
	if (x > 0) {
		return 1;
	}
	else {
		return 0;
	}
}

int main(){

	double *input1 = csvReader("../a1.csv");
	double *input2 = csvReader("../b1.csv");

	Neuron *neuron = new Neuron(64);
	neuron->setFuncAct(funcAct);

	cout << neuron->start(input2) << endl;
	neuron->learn(input2, 0);
	cout << neuron->start(input2) << endl;

	cout << neuron->start(input1) << endl;
	neuron->learn(input1, 1);
	cout << neuron->start(input1) << endl;
	cout << neuron->start(input2) << endl;


	system("pause");
	return 0;
}

double* csvReader(string file){
	ifstream is(file);
	double *input = new double[64];
	int i = 0;
	char  c;
	while (is.get(c)){
		if (c != ',' && c != '\n'){
			input[i] = c - 48;
			i++;
		}
	}
	is.close();

	return input;
}