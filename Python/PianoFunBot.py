import pyautogui
import keyboard
import time
import random
import win32api, win32con

pyautogui.PAUSE = 0
pyautogui.FAILSAFE = False



"""
X:  525 Y:  500
X:  636 Y:  500
X:  721 Y:  500 
X:  833 Y:  500

RED - RGB: (231,  76,  60)
BLUE - RGB: ( 52, 152, 219)
GREEN - RGB: ( 46, 204, 113)
YELLOW - RGB: (243, 156,  18)
"""

colorList = [0,16,14]


def clickpianotile(x,y):
    win32api.SetCursorPos((x,y))
    win32api.mouse_event(win32con.MOUSEEVENTF_LEFTDOWN,0,0)
    time.sleep(0.01)
    win32api.mouse_event(win32con.MOUSEEVENTF_LEFTUP,0,0)

time.sleep(3)

while keyboard.is_pressed('k') == False:
    if pyautogui.pixel(525,500)[0] <= 16:
        clickpianotile(525,500)

    if pyautogui.pixel(625,500)[0] <= 16:
        clickpianotile(625,500)

    if pyautogui.pixel(730,500)[0] <= 16:
        clickpianotile(730,500)

    if pyautogui.pixel(830,500)[0] <= 16:
        clickpianotile(830,500)



