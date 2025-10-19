import pygame

pygame.init()
bg_color = 'blue'
image = pygame.image.load("D:\midownload\生成动态壁纸 (6).png")
image = pygame.transform.scale(image, (image.get_width() * 0.5, int(image.get_height() * 0.5)))
rect = image.get_rect()
screen_size = rect.size
screen = pygame.display.set_mode(screen_size)
while 1:
    pygame.display.flip()
    screen.blit(image, (0, 0))
    
