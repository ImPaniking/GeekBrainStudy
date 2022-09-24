import java.sql.Array;
import java.util.ArrayDeque;
import java.util.Arrays;

public class Programm {

    static void collisionCreation(int StartX , int startY , int length , int[][] array , String dirrection){
        switch (dirrection){
            case "Up":
                for (int i =0 ; i <length ; i++){
                    array[StartX-i][startY] = -1;
                } break;
            case "Down":
                for (int i =0 ; i <length ; i++){
                    array[StartX+i][startY] = -1;
                } break;
            case "Left":
                for (int i =0 ; i <length ; i++){
                    array[StartX][startY-i] = -1;
                } break;
            case "Right":
                for (int i =0 ; i <length ; i++){
                    array[StartX][startY+i] = -1;
                } break;
        }
    }
/*
* ▣
* ■
* □
* */
    static void printMap(int[][] array){
        for ( int[] row : array){
            System.out.println();
            for ( int point : row){
                switch (point) {
                    case -1:
                        System.out.print('■'+ " ");
                        break;
                    case -2:
                        System.out.print('▣'+ " ");
                        break;
                    case -3:
                        System.out.print('▣'+ " ");
                        break;
                    case 0:
                        System.out.print('□'+ " ");
                        break;
                    default:
                        System.out.print('x'+" ");
                        break;
                }
            }
        }
    }
    static void printMap3(int[][] array) {
        for (int[] row : array) {
            System.out.println();
            for (int point : row) {
                System.out.printf("%4d", point);
            }
        }
    }

    static void pathLookUp(int X , int Y , int[][] array , int count , int mapWidth , int mapHeight){
        if ((X >= 0) & (X < mapWidth) & (Y >= 0) & (Y < mapHeight)){
            if (array[X][Y] != -1) {
                if (array[X][Y] == 0 | array[X][Y] == -2){
//                    if (array[X][Y] == -3) return;
//                    else {
//                        array[X][Y] = count++;
//                        pathLookUp(X--,Y,array,count,mapWidth,mapHeight);
//                        pathLookUp(X,Y++,array,count,mapWidth,mapHeight);
//                        pathLookUp(X++,Y,array,count,mapWidth,mapHeight);
//                        pathLookUp(X,Y--,array,count,mapWidth,mapHeight);
//                    }
//                    if (test(X-1,Y,array)){pathLookUp(X-1,Y,array,count,mapWidth,mapHeight);}
//                    else if (test(X,Y+1,array)){pathLookUp(X,Y+1,array,count,mapWidth,mapHeight);}
//                    else if (test(X+1,Y,array)){pathLookUp(X+1,Y,array,count,mapWidth,mapHeight);}
//                    else if (test(X,Y-1,array)){pathLookUp(X,Y-1,array,count,mapWidth,mapHeight);}
//                    else return;

                }else return;
            }else return;
        }else return;
    }

//    static void pathCreationQue(int X , int Y , int[][] array , int count , int mapWidth , int mapHeight){
//        count++;
//        ArrayDeque<int[]> a = new ArrayDeque<>();
//        do{
//            int[] point = new int[2];
//            if (test(X-1,Y,array)){
//                array[X-1][Y] = count;
//                point[0] = X-1;
//                point[1] = Y;
//                a.add(point);}
//            if (test(X,Y+1,array)){
//                array[X][Y+1] = count;
//                point[0] = X;
//                point[1] = Y+1;
//                a.add(point);}
//            if (test(X+1,Y,array)){
//                array[X+1][Y] = count;
//                point[0] = X+1;
//                point[1] = Y;
//                a.add(point);}
//            if (test(X,Y-1,array)){
//                array[X][Y-1] = count;
//                point[0] = X;
//                point[1] = Y-1;
//                a.add(point);}
//            for ( int i = 0 ; i < a.size();i++) {
//                point = a.pop();
//                X = point[0];
//                Y = point[1];
//                pathCreationQue(X,Y,array,count,mapWidth,mapHeight);
//            }
//        } while (array[X][Y] != -3);
//
//    }

    static String pointChek(int X , int Y , int[][] array){
        if (array[X][Y] == -3) return "Win";
        if (array[X][Y] > -1) return "Block";
        if (array[X][Y] == 0) return "Path";
        else return "Taken";
    }
    static boolean pointInArrayChek(int X , int Y , int[][] array){
        return ((X>=0) & (Y>=0) & (X<array.length) & (Y<array.length));
    }

    static void pathCreationQue(int X , int Y , int[][] array , int count){
        ArrayDeque<int[]> a = new ArrayDeque<>();
        int[] point = new int[2];
            switch (pointChek(X,Y,array)){
                case "Path":
                    array[X][Y] = count;
                    if (pointInArrayChek(X-1,Y,array)){
                        point[0] = X-1;
                        point[1] = Y;
                        a.add(point);
                    }
                    if (pointInArrayChek(X,Y+1,array)) {
                        point[0] = X;
                        point[1] = Y+1;
                        a.add(point);
                    }
                    if (pointInArrayChek(X+1,Y,array)) {
                        point[0] = X + 1;
                        point[1] = Y;
                        a.add(point);
                    }
                    if (pointInArrayChek(X,Y-1,array)) {
                        point[0] = X;
                        point[1] = Y-1;
                        a.add(point);
                    }
                    break;
                default:
                    break;
            }
    }


    static boolean test(int X, int Y, int[][] array){
        if ((X>=array.length) | (Y>=array.length) | ( X < 0 ) | (Y < 0) ) return false;
        else if (array[X][Y] > 0 ) return false;
        else return array[X][Y] == 0;
    }

    public static void main(String[] args){

        int mapWidth = 14;
        int mapHeight = 14;
        int[][] map = new int[mapWidth][mapHeight];

        collisionCreation(1,1,5,map,"Down");
        collisionCreation(1,1,5,map,"Right");
        collisionCreation(5,5,7,map,"Down");
        collisionCreation(5,5,4,map,"Left");
        collisionCreation(5,5,7,map,"Right");
        collisionCreation(5,5,4,map,"Up");

        int startX = 7;
        int startY = 3;
        map[startX][startY] = -2;
        int endX = 1;
        int endY = 8;
        map[endX][endY] = -3;

        printMap3(map);

//        pathCreationQue(startX,startY,map,0,mapWidth,mapHeight);

//        printMap3(map);


    }


}
