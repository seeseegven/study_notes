import pygame

class Ship:
    '''管理飞船'''

    def __init__(self, ai_game):
        self.settings = ai_game.settings
        self.screen = ai_game.screen
        self.screen_rect = ai_game.screen.get_rect()

        self.image = pygame.image.load('plane.png').convert_alpha()
        self.image = pygame.transform.scale(
            self.image, (int(ai_game.settings.screen_width * 0.1), int(ai_game.settings.screen_height * 0.1)))
        self.rect = self.image.get_rect()
        self.moving_right = False
        self.moving_left = False

        self.rect.midbottom = self.screen_rect.midbottom
        self.x = float(self.rect.x)

    def blitme(self):
        self.screen.blit(self.image, self.rect)

    def update(self):
        if self.moving_right and self.rect.right < self.screen_rect.right:
            self.x += self.settings.ship_speed
        if self.moving_left and self.rect.left > 0:
            self.x -= self.settings.ship_speed

        self.rect.x = self.x
        