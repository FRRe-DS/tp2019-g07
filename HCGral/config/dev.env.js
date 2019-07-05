'use strict'
const merge = require('webpack-merge')
const prodEnv = require('./prod.env')

module.exports = merge(prodEnv, {
  NODE_ENV: '"development"',
  //Dir de mi API local, en vez del localhost => direccionIp compartida
  //API_ENDPOINT: '"https://172.20.10.3/api"' 
  API_ENDPOINT: '"http://localhost:3000"'
})
