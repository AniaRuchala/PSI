#pragma once
typedef double(*fun1)(double x);

class Neuron
{
public:
	Neuron();
	Neuron(int n);
	Neuron(int n, double *waga);
	~Neuron();

	double start(double *m_input);
	double getWaga(int i);
	int getN() { return n; }
	void setN(int m_n);
	void setWaga(double *m_waga);
	void setWaga(double x, int i);
	void setFuncAct(fun1 funkcjaAktywuj¹ca);
	void setPochodna(fun1 m_pochodna);
	void learn(double *input, double output);
	fun1 getPochodna() { return pochodna; };


private:
	double *waga;
	int n;
	fun1 funcAct;
	fun1 pochodna;
	double sumowanie(double *m_input);
};

