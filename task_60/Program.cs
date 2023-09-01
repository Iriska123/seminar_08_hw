/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int x =2, y = 2, z = 2;

int[,,] res = GetArray(x,y,z);
PrintArray(res);


int[,,] GetArray(int x, int y, int z){

    int [,,] arr = new int[x,y,z];

    for (int i = 0; i < x; i++){
        for (int j = 0; j < y; j++){
            for (int k = 0; k < z; k++){
                while(true){
                    int rand = new Random().Next(10,100);
                    if(!IsDuplicate(arr,rand)){
                        arr[i,j,k] = rand;
                        break;
                    }
                }
            }
        }
    }
    return arr;
}

void PrintArray(int[,,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            for(int k = 0; k < array.GetLength(2); k++){
            Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        //Console.WriteLine();
    }
}

bool IsDuplicate(int[,,] array, int value){
    bool duplicate = false;
     for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            for(int k = 0; k < array.GetLength(2); k++){
                if(array[i,j,k] == value){
                    duplicate = true;
                    break;
                }
            }
        }
    }
    return duplicate;
}