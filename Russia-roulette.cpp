//Russian Roulette 
#include <iostream>
#include <ctime>
#include <chrono>
#include <unistd.h>

using namespace std;

int main(){
 srand(time(NULL));

 bool dead = false;
 int round = 1;
 
 cout << "Russian Roulette" << endl;
 
 
 while(round <= 6 && dead != true){
        int random = rand()%6 + 1;
        cout << "Round " << round;
        usleep(300000);
        cout << ".";
        usleep(300000);
        cout << ".";
        usleep(300000);
        cout << ".";
     if(random == 5){
       dead = true;
       cout << "Bang!"<< endl << "You lost. You lasted " << round << " rounds." << endl;
     }
     else{
       cout << "Click." << endl;
       dead = false;
     }
     round++;
 }
 
    if(dead==false){
        cout << "You won! You lasted all rounds." << endl;
    }
}