#include "Game.h"
#include "iostream"
#include "ctime"
#include <vector>

using namespace std;
namespace Libary {
    Game::Game(int e_rows, int e_cols) {
        rows = e_cols;
        cols = e_cols;
        matrix = vector<vector<int>>(rows, vector<int>(cols, 0));
    }

    Game::~Game() {  
        matrix.clear();
        matrix.shrink_to_fit();
    }

    void Game::CreateMatrix() {
        srand(time(0));

        int k = 0;
        for (int i = 0; i < rows; ++i) {
            for (int j = 0; j < cols; ++j) {
                k += 1;
                matrix[i][j] = k;
            }
        }

        k = 0;
        while (k < lvl) {
            int r = rand() % (rows * cols);
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    if (matrix[i][j] == r) {
                        k++;
                        matrix[i][j] = -1;
                    }
                }
            }
        }
    };
    int Game::GetValue(int i, int j) {
        return matrix[i][j];
    };

    void Game::SetValue(int i, int j, int value) {
        matrix[i][j] = value;
    };

    bool Game::CheckCell(int a, int b) {
        if (matrix[a][b] == -1)
            return true;
        else
            return false;
    };
    void Game::LvlUp() {
        lvl++;
        wins++;
        loseStreak = 0;
    };
    void Game::LvlDown() {
        if (loseStreak >= 2)
        {
            lvl--;
            loseStreak = 0;
        }
        else
        {
            loseStreak++;
        }
    };
    void Game::SaveData() {};
    void Game::LoadData() {};
}
