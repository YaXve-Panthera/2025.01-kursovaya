#include "Game.h"
#include "iostream"
#include "ctime"
#include <vector>

using namespace std;
namespace Libary {
    Game::Game(int e_rows, int e_cols, int e_lvl) {
        startlvl = e_lvl;
        lvl = e_lvl;
        rows = e_rows;
        cols = e_cols;
        matrix = vector<vector<int>>(rows, vector<int>(cols, 0));
        /*for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++) {
                cout << matrix[i][j] << " ";
            }
            cout << "\n";
        }*/
    }

    Game::~Game() {  
        matrix.clear();
        matrix.shrink_to_fit();
    }

    void Game::StartGame() {
        CreateMatrix();
        current = lvl;
        gameState = 1;
    };

    void Game::WinGame() {
        LvlUp();
        gameState = 2;
        if (lvl == rows*cols)
        {
            gameState = 3;
            lvl = startlvl;
        }
    };

    void Game::LoseGame() {
        LvlDown();
        if (lvl != 0) {
            gameState = -1;
        }
        else {
            gameState = -2;
            lvl = startlvl;
        }
    };

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

    bool Game::CheckCell(int i, int j) {
        if (matrix[i][j] == -1){
            current--;
            if (current == 0)
            {
                WinGame();
            }
            return true;
        }
        else
        {
            LoseGame();
            return false;
        }
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

    void Game::setGameState(int state) {
        gameState = state;
    };
}
