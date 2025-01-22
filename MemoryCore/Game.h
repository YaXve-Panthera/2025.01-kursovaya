#pragma once
#include <vector>
using namespace std;



namespace Libary {
    class Game {
    public:
        int rows = 1;
        int cols = 1;
        vector<vector<int>> matrix;
        int lvl = 1;
        int startlvl = 1;
        int loseStreak = 0;
        int wins = 0;
        int loses = 0;
        int games = 0;
        int rec = 0;
        int gameState = 0;
        int current = 0;

        Game(int e_rows, int e_cols, int e_lvl);

        ~Game();

        void StartGame();
        void WinGame();
        void LoseGame();


        void CreateMatrix();
        int GetValue(int i, int j);
        void SetValue(int i, int j, int value);
        bool CheckCell(int a, int b);
        void LvlUp();
        void LvlDown();
        void SaveData();
        void LoadData();
        void setGameState(int state);
    };
}
