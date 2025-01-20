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
        int loseStreak = 0;
        int wins = 0;

        Game(int e_rows, int e_cols);

        ~Game();

        void CreateMatrix();
        int GetValue(int i, int j);
        void SetValue(int i, int j, int value);
        bool CheckCell(int a, int b);
        void LvlUp();
        void LvlDown();
        void SaveData();
        void LoadData();
    };
}
