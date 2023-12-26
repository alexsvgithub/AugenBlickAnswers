

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;

public class HelloWorld
{
    public static void Main(string[] args)
    {

        string s =
        @".#.OO.O.#OO........O....O..OO....OOO...#....#..........#.O.OO.....O#.#..#..#O##.O..#.#.O#.O.OO.....#
        .O##.#..O..##..#..#.#..O#....O##..#.....##.......O...O#O..O.......#..#..O#O...#O..OO.#.....O.##.#.##
        #.O...O.#.O....#.O..#OO...O...#.#.##...........#....#O.....##..#.O.#.............O...O..O.O...##...#
        .#.#.....O..#...#...O.####OO....#.O...O...O...O.....OO#.O.##O.............O...#O.#OO#......O........
        OO.O.....O....O..OO..O#..OO.OOO..OO...........O..##.O...O.#.O...##.O##....O.OO.#.O.....O..#.O...O##O
        .#..##....#.O#...........#..OO...O......O.......#O..O..#...O......#.#....#.OO#..#O...O...#.....O..O#
        ##..OO.##.#........OOO##...OO.OOO#O...OOO.O.O...#...#.##..O##...#.#O#....#........#.O....#O.#O.O..O.
        ...O.O.O#...O.....O..OO...#O..#.#...O......#.......#.O...O.O#....O......#.OO.O..OOO.OO.O.O.###O...OO
        ...#O.....#O..##..#O.#...O.#...OO#O#.#..#.#....O..O.O.#...O.O...O.#..##O...O.#.OO.#O...OO.O.#O.OO#..
        #.....#.#.O..#....O....##.O#......OO#....O#.#O.#..#O..#OO..#O..O...##O..#.....O##...O#.#..OO....O..#
        .#OOO...#O...#...##...#O....#O..........O.#.O.O#..#..#OO.#............#....O#.#O....#....OO..#...O.O
        #...OO...O...O..O.#.........O#O##..O........O.#..#O#O.##....#...#O.....OOO.#......#....O.O..#.OO.#..
        .OO.....#..##...#.O.#O.#...##..#...#O.#...O#........O.O....#.##....O...#..#...#.O....OO..OO....O..#.
        #..#.....OO....#O.#.O...O.OOO..O..O.#.O...OOOO..O.O...#..OOO...#......#.###.O.O....O.......O....O.#.
        .#O.#....O....O#.OO..O.OOO...........O.##........O#O..#...O.#...O....O..O.##.#O#.#OO.O...O#...#..#O.
        .OO.#O.#..O.O.OO...O.O....OOOO#.O.O.#.#.O.#.#....OO.#....#..#.....##...O....OO.OO...#.O.O...O.....OO
        ...###..O......#O.....#.....#...O.......O.#O.O..#..........OO..O.#..O...#..#.O.O....#..#.#...O.OOO..
        ........O..O.......O.......O#.O.O...#.#....#........#.#....OO....#.#........###.#...O...#OO.O#.#....
        .OO#...........#......#.......#....O......#......##.O......OO.O#...O...O....O######O#..O..O.....OO..
        .O.........OOO#O.#O...#.O....OOO##.......O.#..O..#..#O........O.OO..O..#...#O#..##..O#.###....OO....
        .#.#.#O..#..#OO...O......O....OO..O......O......#..O..#...O.#..O...#....OOO....OO.OO#O....O.#.......
        ..OO..O.O..O#..#......OO.........#.O..O.O..#......#OO.#..O.O.#O#..O.#O...O.O..O.#......O...OOO.OO..#
        O.O##....O.O....#.....#...OO..O..#.##..O..O###....#...O.#.O#O.OO.OO#.#...#.....#.#....O...#OOO..O#..
        #.#.O.#O.O#.#...O..OOO.O.#.#......O..#O.#..##.##..#.........O...#OO...#..O.....#O...O..##O#O........
        ..O#O.##O.O.#.....#.OO..O.....OOOO#O....O..O.##O#..O..#..O#....##OO#..O...O..##..#O.##.........O#..O
        #.#.#..##..O.O#O...##.#.O....#..#.O#..#....O.....#.#.....#.O.#O.....O.#.##...#..O.O.OOO..O...O......
        ....#....O..OO.#...O.O#.#.##..O....O..OO.#....O...O...O.....#......#..OO#OO.OO#..#.O#....#.#.OO..##O
        O.##O.O.O....O..#......O..O.#O#O....#O....#.#.#.#O.........OO..O....O.#......O##OO......OOO..#O..#..
        #.O.O.OO.O..#.....#O..#......O.......#....O.....O.....#...O.#.O......#...###...OO.#..O.OO#.O#..O#.OO
        .....O.#.##OOOOOO#.#OO#O..#...#.........O..O.OO...OO....O..O.......O..O...#.#OO#.O.........O......O.
        O......#..OO.O..O.......#..#...#..O.OO.#..##..#.O...#.O.#.O#O##.O.#.#..#..#....O.....#.#..O.....O#..
        #.....#O...O.O......O......O.O.OO.O#O..#...O..#....#.....#O..O..#O...O..O.OO##.#.##O.#..#..#.#.....O
        O#.O##..###.........O.....O.#.O#....#O.O..O.O#O#....OO..#O..O.....OO.O##..OO.#......#.O......###....
        ..O....#...OO.OO#.O#.O.OO#..O...##..OO..O#O#..OO..#.....OO...........O....#...#.......O#....O#......
        ....#.#O.O..OO......##.OO.#..##O.....#.......#.........O.O..OO.OO...#.#O.#O...OOOOO..O...OOOO.O#.#..
        ....#O##.OO#O..O.O.O#O.#O#..###....OO.....#OO..O.........O.O....OO.O..#..O#..OO...O#O.O.O.......O#..
        O.O#.O.#.OO....OOO.O.O.O...OO.#.O.##..O..O.#..OO.#..O............#O.##.O#.OO.O.##..#....#..OO.O...#.
        .#...O.#.#.#.O.#..##.O##.#..O..O...#.......O...OO.....#...#.OO#..O.OO....O....O.....#O.O#OO.##OO..O.
        O#OO.OO..O..O.......O#.O....OO...O.........OO#.#O#O#.OO....#..#...O...OOO#...O.#O.#...........OO.O#.
        ..OO#..O...OO#O..#..#.#...#......O....O#..O.O....O#...##.....O..#O#..........O#.#......#.#.#OOO..O.O
        .OO.......OO.#...O...O#.O...#..OO.##........O.........O..OOO.O..#......O#.OO.O....O.#..OOO....O..O.O
        O#.O.#..O#..#O.#..O.O...##...O#.#O#...#O......O#.....#.###..#....O.....#O#....#....O#.O.O..#OO.O...O
        .O...O...O...O.#.OO....#...O.O..........O...#...#........##..........##...#..O.O.O#O#.#......O..O...
        .#.#..#O.#.....O.#....##........#....#....O.#O.O..............O.O....#..O.O.#O....O#O........#....O.
        O....###O...O..O...OO.....#......O#.O..OO.#.#.O#....#O..#.O..OO..#..O.#.O..#....O...#OO.....O.OO.O..
        #O.O.O.#O...#.OO...........#....O...#O.......#...##..##.##.O.O..........OOO..O..#..OO..O..OO..#.#.#.
        #.O#..#..O.OOOO....OO.#O##.##..#..OO##O#.#.O....O.O#.##.O#...OO.O......#..#...O........O...#.##O..#.
        ......#...O......#......O.#..O.OOOO.O.O......#.#O...O#....O..#...........O.O..#...#..#O..O.O..##O..O
        ..O.#.....#...O.O..O....O.....#.....#.....O..O.O.O#O.#.....#.#OOOO...O.....O.#..#O..O.OOO....#OOO.O.
        .OOO....O#.........O.......#..O......#..........#...##O...O...O...O.O.O##....O#O##.......##O...#..O.
        #.##.O.O....O......##..#.....##..##..O#....O.#O#.O....#........#.#.#....OO.O.........OO..O......#O#.
        #.O.......#O#.O....O.O.......O.O##O#....#O.O.#O#.O.O.OO..#.O#...O.##.###.O.O#.O..#...#O.....OO....##
        ..O......O...#..#.O#....##O......OO......O.O....O....O#...O.O.OOO.#O...O.#..O......OO...#.O#.....#.O
        .OO...#O.O....O.........##......##.......#...O..##.....#...OO.....O...#.#....O..O...O#.......O..O.O.
        .O#.....O....O..O...#.O.O#...#.#..#O#.O.....O#O.OO....#....O..OO.OO.#..#.#.O.O.....O..O......O..#..#
        .O.#...O...O.OOO#O...#........O..#..#.##..#...#...#..O....##.O.O#...O.....O.##.O........O...#O#O#.O.
        .#O....#.O#O##O......O........#...##.#..O.OO..O.....#.#.O#...O.O#.#...#.......#...#.#.O.....O.OOO...
        .O....OO###...O#...O..#..O............#O.#.O.......OO...O...##......O.#..O.O#.#....O..O.#....O...##O
        #..#O#.O...O....OO..O..........OO##.....O......O...##O.#..O..OO#...#.OO..#...#.O..O...O.O#.....#....
        O.O#OO.....O#.O..##.OOO.##....O#...O..#.#...O..OO......O#..O..O..#...#O........##.O##....#O.....OO.O
        ......O..O..O....OOO..O...O.O#..#.....O..O..#....#.O##....O.#..##O...O..O..OO....#...O.#..O..OO...#.
        ..........O.#O#.#......#......#O..O.O.OOOOO.#...O..#.O.OO....#.O#.#O..#......#.#O.O.O...O..##..O#.O.
        OO#...#...OOO..O.#.......#.O...##..O.O......#..O.......##.....O..O.....OOO.##..O..O.#...#O.......#.#
        ....##..#..O......OO.......O#O#O...O.O.#.#..#..##..##O....O.#.........#.O...#..O........O..#..#O.OO.
        ......O.O...OO##..O..##.O#O#..O##.O#..#...O##....#.......#....#OO.O.####O...###O...#.........###O..O
        .#.O#.#O..#..#...#O..O..#..........#.......O..#.O...O.#..#O..O...O..#..O.............#.OO....O#..OO.
        .....#.O.OO...#...O...O..........#......#..O.O....OO.#..#...O#O..#.....OO........O.#O.#.......OO#.OO
        OO...#.O.......#O.O...O#.O....O.....OO.O.........##OO...OO...O.#..OO...O.#.O...O.O..O#OO.O#O..#..OO.
        ..O##.#..#...O..O.#....O.O##.O.#.O...O..#O.OO...O.#.....##O...O.O.......##O...OO..O#..O#.#......O.O.
        .....O.....OO..O..O..O.#...O......O..OO..OO....OOO#.O..OO......#.O.....#O.O.O#....##OO..#O#.O..O#O.O
        ......O.O#...O..O.OO.O.OO.OOO...#O..O#...OO.#O.OO...O..#..O..O.#....O..OO....#......O.O.#O.##..O..O.
        #.....#....O#O..O#O....O.......#.....O....#..#.OOOO#OOO#..#.OO....OO.O#.O......#..O.OO..O.#....O.O..
        .O.O.#.#.O...#..#O.......##...OO..O...#......#.O#...O..O....#O.O.O.........#O.O#..O....##.O.O.......
        ....#..O.#.......#.#O..O..........#...#..O##..O#..O..OO.O###.#O#..O#O#O..#OO.#..O#.#.O..#....O.O....
        ...##...........O...#O.OOO..##O.O...#.OO.OO..O...O.....#.......#.....#........#....##.....O...#.#..O
        .O......O.#...##O..#O..O......O#O....#.......O....#...O#....O.....#......#O..#.O..#.#.O.O#...O#.....
        O..O.#........O.##.#..##....O.OO.......O.......O..#O#O......O...###.........OO...#.#..#........#.#..
        O.........#..O.O...#O......#.O.#OO..O.##..O.#O.#..#..#.#.O.....#...#.....##....#.......O##...O#..O..
        #OO..........O.O...#.OO....#...#.O#..OO#..#O.##.O....#O#..O....O..#...#.#....O.O...#.#O....OO.#.##..
        .#...#O.#O#O###.OO.#..#....#OO.O....O.O#.O...........O#....O.#.O......#.O.#.#O.#..O.OO.....OO...OO.#
        O#.........O....O.#....##.....O.....O.........#O.O#O...O.O#..O.#O....#.#...O....O#....##.......#....
        .....OO#..O##..O.......O.#...#.OO.O.........#..O###...#.O..O#.O......O.....#.O.OO......#O...O#.....O
        .O.O##.###OO..........O.......OOO..O.OO..##...#O..O...OO..#.O.....O.#..#.O.OO##.#.#...###....O...#..
        .O..###...O...#.OOO#.O#.O#...O.#OO.OO...O..#.O......#.O.O.OO...#OO..#...#..O#O...O........##.OO.#...
        .#..#O......#O......O#...#..#O...##O..#.O..O....O.#O..OO..O..#.#....O..O......O.O.#...##..O.O.#O....
        .O.##.#...#O..#...O#.#.O..O#.......O....#.O.O.#.##.....#.......O.##..#.......O.....##.O.#.....#..#O.
        ...#.O.O.#O#.#...#...#OO.#O..O....O...O#....#.#.O..O..OO.#.OO..O...#O....O..#.......OO...O.....#.O..
        O..O...O.......O.....##O#.O.#...OOO.O...........#..O..O.O.....O............#...........#...O.O..#.O.
        ..O.O.#O...O#.#.#O.OO.....##..O##O.O.O....#OOO...##.O.O.OO........O.#O........O.#.O.#.O.OO....O#.OO.
        #.O.O##.....OO..#OO.O...O.#..#......O...OO....OO.#...O.##.O.OO.#.##..##O.O...#O#...##.....#..O#O.##.
        ..#OO..OO.##..#....O##.#O.OO##.O....#....O...O.........O....O#O.##.OOO.#..#......OO#..OO...#..#..#O.
        .....#.#.O...O##....O.#O..O.#..#..O.#O.#O##..O.#..#O.#.O..O.......##......O#.##.O#..OO.....O#OOO.#..
        O....O.O#.#...O.OO.........O...#...#...OO..##..OO..........#O.O.....#.#.OO.#..O#O.#...OO..O##.#.O...
        ..#....##..............O..#.#..OO.OOO..#OO.O#O.OO#..#...O.#...O..O...OO......#.O..#....O.OO.O....##.
        O.#O##....#.OO....#.#...#.....O......O......#.#......#OO.....###...#...#..O...O...O.OO.#...#.......#
        ....O..#....#....O...#...O....OO.O##..#.O..OO.#.#.#......#O.OO......O##O.#O...#.#.....O....#O..O....
        #OO.#..O......#.....#........#...#.....O...OOO.......OO##O....#......O.O...O##.O.OOO.#........O.#...
        O.OO.......O..OO.O.OO.OO..OO#...##.#.....#...O.#.O....O...#.OO.##.#.....OO..O#......#OOOO....O....##
        ...#...#..#....#.....O..O#O..#.##O.O......O.#O......O..##...#O#O..##..O.#....O.#...O.OO...#O#....OOO
        .........OOOO.O.O.O...#........#....OO.#OO#....#O........#.....#O.....##O.....#O..O.O...#...#....OO.";
        char[] c = s.ToCharArray();
        List<List<char>> mainList = convertToListofChars(s);
        List<List<char>> TransformedList = TransformList(mainList);
        int sum = sumOfTransformedReflectorDish(TransformedList);

        Console.WriteLine(sum);

    }


    public static List<List<char>> convertToListofChars(string s)
    {
        List<List<char>> returnList = new List<List<char>>();
        List<char> current =  new List<char>();

        char[] chars = s.ToCharArray();
        foreach(char c in chars)
        {
            if(c != '\r' && c != '\n' && c!=' ')
            {
                current.Add(c);
            }
            if(c == '\n')
            {
                returnList.Add(new List<char>(current));
                current.Clear();
            }
        }
        //For last lap of loop
        returnList.Add(new List<char>(current));
        return returnList;
    }

    public static List<List<char>> TransformList(List<List<char>> mainList)
    {
        int up = 0;
        int factor = 1;
        int tempCounter = 0;
        bool counter = true;
        for(int i = mainList.Count -1; i >= 0; i--)
        {
            for(int j = 0; j < mainList[0].Count; j++)
            {
                if (mainList[i][j] == 'O' && i>0)
                {
                    if(mainList[i-1][j] != '#' && mainList[i - 1][j] != 'O')
                    {
                        mainList[i - 1][j] = 'O';
                        mainList[i][j] = '.';
                        tempCounter = i;
                        if(tempCounter != mainList.Count - 1)
                        {
                            while (mainList[tempCounter + 1][j] == 'O')
                            {
                                mainList[tempCounter][j] = 'O';
                                mainList[tempCounter+1][j] = '.';
                                if (tempCounter + 1 < mainList.Count - 1)
                                {
                                    tempCounter++;
                                }
                                else
                                {
                                    tempCounter = 0;
                                    break;
                                }
                            }
                        }
                        
                      
                    }
                }
            }
        }
        return mainList;
    }

    public static int sumOfTransformedReflectorDish(List<List<char>> TransformedList)
    {
        int sum = 0;
        int number = TransformedList.Count();
        int counter = 0;
        char compareChar = 'O';
        for(int i = number; i > 0; i--)
        {
            sum += i * TransformedList[counter++].Count(x => x == compareChar);
        }
        return sum;
    }


}




// Output : 110274