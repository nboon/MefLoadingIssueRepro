# MEF Composition failing to correctly discover parts when assembly loaded using LoadAssemblyFromContext in 8.3.6

Steps to reproduce:

1. Install dependencies `npm install`
2. Build `npm run build`
3. Run the app `npm start`

This throws System.Composition.Hosting.CompositionFailedException.

4. Delete `electron-edge-js-quick-start-master\node_modules\electron-edge-js`
5. Change electron-edge-js version from 8.3.6 to 8.3.5 in package.json dependencies
6. Reinstall electron-edge-js `npm install`
7. Build `npm run build`
8. Run the app `npm start`

Call to method in loaded assembly completes without errors


