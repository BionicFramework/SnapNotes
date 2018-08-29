importScripts('/cache-polyfill.js');

self.addEventListener('install', function (e) {
    e.waitUntil(
        caches.open('snapnote').then(function (cache) {
            return cache.addAll([
                '/',
                '/css/App.css',
                '/capacitor.js',
                '/cache-polyfill.js',
                '/_framework/blazor.webassembly.js',
                '/css/bootstrap/bootstrap.min.css',
                '/css/open-iconic/font/css/open-iconic-bootstrap.min.css',
                '/_framework/blazor.boot.json',
                '/_content/Bionic.Bridge.Capacitor.JS',
                '/_framework/wasm/mono.js',
                '/_framework/wasm/mono.wasm',
                '/assets/icon/favicon.ico',
                '/_framework/_bin/SnapNotes.dll',
                '/_framework/_bin/Bionic.Bridge.Capacitor.JS.dll',
                '/_framework/_bin/BionicBridgeCapacitor.dll',
                '/_framework/_bin/BionicExtensions.dll',
                '/_framework/_bin/Microsoft.AspNetCore.Blazor.Browser.dll',
                '/_framework/_bin/Microsoft.AspNetCore.Blazor.dll',
                '/_framework/_bin/Microsoft.Extensions.DependencyInjection.Abstractions.dll',
                '/_framework/_bin/Microsoft.Extensions.DependencyInjection.dll',
                '/_framework/_bin/Microsoft.JSInterop.dll',
                '/_framework/_bin/Mono.WebAssembly.Interop.dll',
                '/_framework/_bin/mscorlib.dll',
                '/_framework/_bin/netstandard.dll',
                '/_framework/_bin/System.Core.dll',
                '/_framework/_bin/System.dll',
                '/_framework/_bin/System.Net.Http.dll',
                '/css/open-iconic/font/fonts/open-iconic.woff',
                '/index.html',
                '/images/logo-full.png',
                '/images/logo-full-192.png',
                '/images/logo-full-512.png'
            ]);
        })
    );
});

self.addEventListener('activate', function (e) {
    console.log('[ServiceWorker] Activate');
});

self.addEventListener('fetch', function (e) {});