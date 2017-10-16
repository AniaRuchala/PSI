#include "Neuron.h"
#include <cstdlib>
#include <iostream>
#include <ctime>

double randFun(double fMin, double fMax){
	double f = (double)rand() / RAND_MAX;
	return fMin + f * (fMax - fMin);
}

Neuron::Neuron(){
	srand(time(NULL));
	waga = NULL;
	funcAct = NULL;
}

Neuron::Neuron(int m_n) : n(m_n){
	srand(time(NULL));
	funcAct = NULL;
	waga = new double[n];
	for (int i = 0; i < n; i++){
		waga[i] = randFun(0, 1);
	}
}

Neuron::Neuron(int m_n, double *m_waga) : n(m_n), waga(m_waga){
	funcAct = NULL;
	srand(time(NULL));
}

void Neuron::setWaga(double *m_waga){
	waga = m_waga;
}

void Neuron::setWaga(double x, int i){
	if ((waga != NULL) && (i < n)){
		waga[i] = x;
	}
	else{
		throw "Error in setWagi";
	}
}

void Neuron::setN(int m_n){
	n = m_n;
}

void Neuron::setFuncAct(fun1 m_funkcjaAktywuj¹ca){
	funcAct = m_funkcjaAktywuj¹ca;
}

void Neuron::setPochodna(fun1 m_pochodna){
	pochodna = m_pochodna;
}

double Neuron::getWaga(int i){
	if (waga != NULL && i < n){
		return waga[i];
	}
	else{
		throw "Error in getWaga";
	}
}

double Neuron::start(double *m_inputs){
	if (funcAct == 0) {
		throw "Set activate function!";
	}
	double a = sumowanie(m_inputs);
	return funcAct(a);
}

void Neuron::learn(double * input, double output){
	if (funcAct == 0) {
		throw "Set activate function!";
	}

	double ni = 0.5;
	double result = this->start(input);
	if (result != output){
		for (int i = 0; i < n; i++){
			waga[i] += ni*(output - result)*input[i];
		}
	}
}

double Neuron::sumowanie(double *m_input){
	double amount = 0;
	for (int i = 0; i < n; i++){
		amount += waga[i] * m_input[i];
	}
	return amount;
}

Neuron::~Neuron(){
	delete waga;
}