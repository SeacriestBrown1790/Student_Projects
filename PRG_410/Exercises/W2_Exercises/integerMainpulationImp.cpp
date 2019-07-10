#pragma once
#include <iostream>
#include "integerManipulation.h"

using namespace IM;
using namespace std;

    long long num;
    long long revNum;
    int evensCount;
    int oddsCount;
    int zerosCount;
    int digitSum;
    
integerManipulation::integerManipulation(long long n)
{
   num = n;
   revNum = 0;
   evensCount = 0;
   oddsCount = 0;
   zerosCount = 0;
}

void setNum(long long n)
{
   long long num = n;
}

long long getNum()
{
   return num;
}

void reverseNum()
{
      int remain;
      while(num!=0)
      {
          remain = num % 10;
          revNum = revNum * 10 + remain;
          num /= 10;
      }
}

void classifyDigits()
{
      int x = sizeof(num);
      for (int i = 0; i < x ; ++i )
      {
          int rem = x % 2;
          
          if (x == 0)
              zerosCount++;
          else if(rem == 0)
              evensCount++;
          else
              oddsCount++;  
      }
}
int getEvensCount()
{
   return evensCount;
}

int getOddsCount()
{
   return oddsCount;
}

int getZerosCount()
{
   return zerosCount;
}
int sumDigits()
{
   int x = sizeof(num);
   for(int i = 0; i <= x; ++i)
      {
          digitSum += x;
      }
      return digitSum;
}
