const path = require('path');
const { fs, util } = require('vortex-api');

const STEAM_ID = '1084600';
const GAME_ID = 'mytimeatsandrock';

function findGame() {
  return util.GameStoreHelper.findByName('My Time at Sandrock')
    .catch(() => util.GameStoreHelper.findByAppId([STEAM_ID]))
    .then(game => game.gamePath);
}

function setup(discovery) {
  return fs.ensureDirWritableAsync(path.join(discovery.path, 'BepInEx', 'plugins'));
}

function main(context) {
  context.requireExtension('modtype-bepinex');
  context.registerGame({
    id: GAME_ID,
    name: 'My Time at Sandrock',
    logo: 'gameart.jpg',
    mergeMods: true,
    queryPath: findGame,
    queryModPath: () => path.join('BepInEx', 'plugins'),
    executable: () => 'Sandrock.exe',
    setup,
    requiredFiles: [
      'Sandrock.exe'
    ],
    environment: {
      SteamAPPId: STEAM_ID,
    },
    details: {
      steamAppId: STEAM_ID,
    },
  });

  context.once(() => {
    if (context.api.ext.bepinexAddGame !== undefined) {
      context.api.ext.bepinexAddGame({
        gameId: GAME_ID,
        autoDownloadBepInEx: false,
        doorstopConfig: {
          doorstopType: 'default',
          ignoreDisableSwitch: true,
        }
      })
    }
  })
}

module.exports = {
  default: main
};
