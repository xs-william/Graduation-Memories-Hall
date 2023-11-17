// index.js
// pages/index/index.js
Page({
  navigateToMemorialAlbum: function() {
    wx.navigateTo({
      url: '../memorial_album/memorial_album'
    })
  },
  navigateToMemoryMap: function() {
    wx.navigateTo({
      url: '../memory_map/memory_map'
    })
  }
})
