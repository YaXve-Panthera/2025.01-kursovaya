#pragma once
#include "../MemoryCore/Libary.h"
#include <vector>

using namespace System;
using namespace Libary;
using namespace std;

namespace MemoryWrapper {
	public ref class ManagedGame
	{
	private:
		Game* nativeGame;
		int rows, cols;
	public:
		ManagedGame(int r, int c) {
			rows = r;
			cols = c;
			nativeGame = new Game(r, c);
		}

		~ManagedGame() {
			delete nativeGame;
		}

		void CreateMatrix() {
			nativeGame->CreateMatrix();
		}

		int GetValue(int i, int j) {
			return nativeGame->GetValue(i, j);
		}

		cli::array<int, 2>^ GetMatrix() {
			cli::array<int, 2>^ result = gcnew cli::array<int, 2>(rows, cols);

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					result[i, j] = GetValue(i, j);
				}
			}

			return result;
		}

		bool CheckCell(int a, int b) {
			return nativeGame->CheckCell(a, b);
		}

		void LvlUp() {
			nativeGame->LvlUp();
		}

		void LvlDown() {
			nativeGame->LvlDown();
		}

		void SaveData() {
			nativeGame->SaveData();
		}

		void LoadData() {
			nativeGame->LoadData();
		}
	};
}
