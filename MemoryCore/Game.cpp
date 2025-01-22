#define _CRT_SECURE_NO_WARNINGS
#include "Game.h"
#include "iostream"
#include "ctime"
#include <vector>
#include <string>
#include <fstream>
#include <filesystem>

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
        wins++;
        games++;
        gameState = 2;
        if (lvl == rows*cols)
        {
			SaveData();
            gameState = 3;
            lvl = startlvl;
            
        }
    };

    void Game::LoseGame() {
        LvlDown();
        loses++;
        games++;
        if (lvl != 0) {
            gameState = -1;
        }
        else {
            SaveData();
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

        if (lvl > rec)
            rec = lvl;
        loseStreak = 0;
    };
    void Game::LvlDown() {
        if (loseStreak >= 1)
        {
            lvl--;
            loseStreak = 0;
        }
        else
        {
            loseStreak++;
        }
    };

    void Game::SaveData() {
        time_t current_time = time(nullptr);
        char date_string[100];
        strftime(date_string, sizeof(date_string), "%d.%m.%Y_%H-%M-%S", localtime(&current_time));

        filesystem::create_directories("data");

        string tim = date_string;
        string txt = ".txt";
        string file = filesystem::current_path().string() + "/data/" + tim + txt;
        ofstream fout;
        fout.open(file);
        if (!fout.is_open())
        {
            cout << "Ошибка открытия файла" << endl;
        }
        fout << date_string << endl;
        fout << rows << endl << cols << endl;
        fout << games << endl;
        fout << wins << endl;
        fout << loses << endl;
        fout << rec << endl;
        fout.close();
    };

    void Game::setGameState(int state) {
        gameState = state;
    };
}
