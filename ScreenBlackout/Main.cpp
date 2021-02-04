#include <Windows.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int WINAPI WinMain( HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nCmdShow)
{
	HDC screen = GetDC(NULL);
	
	SelectObject(screen, GetStockObject(DC_BRUSH));
	SetDCBrushColor(screen, 0x000000);

	do{
		Rectangle(screen, 0, 0, 1920, 1080);
	} while(!GetKeyState(VK_ESCAPE));
		
}

