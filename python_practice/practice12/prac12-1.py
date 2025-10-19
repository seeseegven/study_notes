import pygame

pygame.init()
bg_color = 'blue'
screen_size = (1200, 800)
screen = pygame.display.set_mode(screen_size)
while 1:
    pygame.display.flip()
    screen.fill(bg_color)
    
